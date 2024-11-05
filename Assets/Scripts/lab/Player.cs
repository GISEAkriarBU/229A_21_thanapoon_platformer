using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;

public class Player : Character,IShootable
{
    [SerializeField]
    private GameObject bullet;
    public GameObject Bullet { get { return bullet; } set { bullet = value; } }

    [SerializeField]
    private Transform bulletSpawn;
    public Transform BulletSpawn { get { return bulletSpawn; } set { bulletSpawn = value; } }

    [field: SerializeField] public float BulletTimer { get; set; }
    [field: SerializeField] public float BulletWaitTime { get; set; }


    public void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && BulletWaitTime >= BulletTimer)
        {

            GameObject obj = Instantiate(bullet, bulletSpawn.position, Quaternion.identity);
            Banana banana = obj.GetComponent<Banana>();
            banana.Init( 20 , this);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        {
            OnHitWith(enemy);
        }

    }
    public void OnHitWith(Enemy enemy) { TakeDamage(enemy.DamageHit); }
    public void Start()
    {
        Init(100);
        Debug.Log($"{Health}");
        BulletTimer = 0.0f;
        BulletWaitTime = 1.0f;

    }

    private void Update()
    {
        Shoot();
    }
    
    void FixedUpdate() 
    {
        BulletWaitTime += Time.deltaTime;
    }



}
