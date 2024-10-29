using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocodile : Enemy , IShootable
{
    [SerializeField] private float attackRange;
    [SerializeField] private Player player;
    
    [SerializeField]
    private GameObject bullet;
    public GameObject Bullet {  get { return bullet; } set { bullet = value; } }
    
    [SerializeField]
    private Transform bulletSpawn;
    public Transform BulletSpawn { get { return bulletSpawn; } set { bulletSpawn = value; } }
    
    [field: SerializeField]
    public float BulletTimer { get; set; }
    
    [field: SerializeField]
    public float BulletWaitTime { get; set; }

    public void Start()
    {
        Init(100);
        Debug.Log($"{Health}");
      
    }
    private void Update()
    {
        BulletTimer -= Time.deltaTime;
        Behaviour();
        if (BulletTimer < 0) 
        {
            BulletTimer = BulletWaitTime;
        }
    }

    public override void Behaviour()
    {
        Vector2 direction = player.transform.position - transform.position;
        float distance = direction.magnitude;
        if ( distance < attackRange ) { Shoot(); }
    }

    public void Shoot () 
    { 
        if (BulletTimer < 0) 
        { 
           Instantiate(bullet,bulletSpawn.position,Quaternion.identity);
        }
     
    }
}
