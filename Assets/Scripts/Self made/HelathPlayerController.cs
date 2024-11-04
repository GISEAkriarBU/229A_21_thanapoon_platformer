using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//intelisence เกิดปัญหาตวรจไม่พบ UnityEngine.UI


public class HelathPlayerController : MonoBehaviour
{
    [SerializeField] private float _maxHealth ;
    private float _currentHealth;
    [SerializeField] private Image _healthBarFill;//intelisence เกิดปัญหาตวรจไม่พบ UnityEngine.UI
    [SerializeField] private float _damageAmount;
    [SerializeField] private Character gameController;
    [SerializeField] private Transform _healthBarTransform;
    private Camera _camera;

    private void Awake()
    {
        _currentHealth = _maxHealth;
        _camera = Camera.main;
    }
    private void Update()
    {
        _healthBarTransform.rotation = _camera.transform.rotation;
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

    private void flip()
    {
        
        Vector2 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

}
