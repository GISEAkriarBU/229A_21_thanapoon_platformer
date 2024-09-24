using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private int health;
    public int Health { get { return health; } set { health = value; } }

    public Animator animator;
    public Rigidbody2D rb;

    public bool Isdead() 
    { 
        return Health <= 0;
    }

    public void TakeDamage(int damage) 
    { 
        Health -= damage;
    }

}
