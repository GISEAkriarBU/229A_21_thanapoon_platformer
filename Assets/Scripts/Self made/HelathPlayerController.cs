using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//intelisence เกิดปัญหาตวรจไม่พบ UnityEngine.UI


public class HelathPlayerController : MonoBehaviour
{
    private float _maxHealth = 100;
    private float _currentHealth;
    [SerializeField] private Image _healthBarFill;//intelisence เกิดปัญหาตวรจไม่พบ UnityEngine.UI
    [SerializeField] private float _damageAmount;
    [SerializeField] private Character gameController;
 
    private void Awake()
    {
        _maxHealth = _currentHealth;
       
    }
    private void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision) // เช็คการtake ดาเมจ
    {
        if (collision.CompareTag("EnemyObject"))
        {
            TakeDamage(_damageAmount);
        }
    }
    private void TakeDamage(float amount) //มาลองรับดาเมจ
    {
        _currentHealth -= amount;
        _currentHealth = Mathf.Clamp(_currentHealth, 0, _maxHealth);
        if (_currentHealth <= 0) { gameController.Isdead(); }
    }

    private void UpdateHealthBar() // ไว้เรองรับการเปลี่ยนแปลงของค่าเลือด 
    {
        _healthBarFill.fillAmount = _currentHealth / _maxHealth;

    }

}
