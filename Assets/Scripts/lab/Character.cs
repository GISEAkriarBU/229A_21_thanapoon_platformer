using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private Healthbar healthBar;
    public int Health { get { return health; } set { health = value; } }

    public Animator anim;
    public Rigidbody2D rb;
    

    public void Init(int newHealth)
    {
        //init health
        Health = newHealth;
        healthBar.SetMaxHealth(Health);

    }
    public float GetHealthPercentage()
    {
        //turn HP into percentage  to use in Fill
        return (float)Health / 100; 
    }

    public bool Isdead() 
    { 
        if ( Health <= 0)
        {
            Destroy(this.gameObject);
            return true;
        }
        return Health <= 0;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log($"{this.name} took {damage} remaining {this.Health} ");
        healthBar.SetHealth(Health, 100);
        Isdead();
    }

}
