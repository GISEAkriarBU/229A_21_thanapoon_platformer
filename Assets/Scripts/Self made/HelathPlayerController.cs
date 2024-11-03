using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HelathPlayerController : MonoBehaviour
{
    private float _maxHealth = 100;
    private float _currentHealth;
    [SerializeField] private Image _healthBarFill;
    //private GameController ประกาศใช้ไม่ได้ 

    private void Awake()
    {
        _maxHealth = _currentHealth;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyObject"))
        {
            TakeDamage(10);
        }
    }
    private void TakeDamage(float amount)
    {
        _currentHealth -= amount;
        _currentHealth = Mathf.Clamp(_currentHealth, 0, _maxHealth);
        if (_currentHealth <= 0) { }
    }

    private void UpdateHealthBar()
    {
       // _healthBarFill.fillAmount = _currentHealth / _maxHealth; ไม่สามารถไปต่อได้ขาดการเข้าถึงสู่ (UnityEngine.UI)
    }

    }
