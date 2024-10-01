using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocodile : Enemy
{
    [SerializeField] private float attackRange;
    [SerializeField] private Player player;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletSpawn;
    [SerializeField] private float bulletWaitTime;
    [SerializeField] private float bulletTimer;
    public void Start()
    {
        Init(100);
        Debug.Log($"{Health}");
      
    }
    private void Update()
    {
        bulletTimer -= Time.deltaTime;
        Behaviour();
        if (bulletTimer < 0) 
        {
            bulletTimer = bulletWaitTime;
        }
    }

    public override void Behaviour()
    {
        Vector2 direction = player.transform.position - transform.position;
        float distance = direction.magnitude;
        if ( distance < attackRange ) {  shoot(); }
    }

    private void shoot () 
    { 
        if (bulletTimer < 0) 
        { 
           Instantiate(bullet,bulletSpawn.position,Quaternion.identity);
        }
     
    }
}
