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
       if (Input.GetButtonDown("Fire1")&& BulletWaitTime >= BulletTimer) 
        { 
         
            Instantiate(bullet , bulletSpawn . position, Quaternion.identity);
        }
    }
    
    public void Start()
    {
        Init(100);
        Debug.Log($"{Health}");

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
