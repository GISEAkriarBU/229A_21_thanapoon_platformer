using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]private int health;
    public int Health { get { return health; } set { health = value; } }

    public Animator anim;
    public Rigidbody2D rb;
    
    public void Init(int newHealth)
    {
        Health = newHealth;
    }


    public bool Isdead() 
    { 
        return Health <= 0;
    }

    public void TakeDamage(int damage) 
    { 
        Health -= damage;
    }
   
}