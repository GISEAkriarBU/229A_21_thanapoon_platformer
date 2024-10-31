using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HealthBarIndicator : MonoBehaviour
{
    private float _maxHealth = 100;
    private float _currentHealth;
    [SerializeField] private Image _haealthBarFill;
 
    
    private void Awake()
    {
        _maxHealth = _currentHealth;
    }



    private void TakeDamage(float amount)
    {
        _currentHealth -= amount;
        _currentHealth = Mathf.Clamp(_currentHealth, 0, _maxHealth);
        if (_currentHealth <= 0) { }


    }

}

