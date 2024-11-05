using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapons
{

    private void FixedUpdate()
    {

        Move();
    }


    [SerializeField]  private float speed ;
    public override void OnHitWith(Character enemyObject) 
    { 
    ///�֡�ҵ�������ѧ
    }
    public override void Move()
    {
        float newLocationX = transform.position.x + speed * Time.fixedDeltaTime;
        float newLocationY = transform.position.y;
        Vector2 newPosition = new Vector2(newLocationX, newLocationY);
        transform.position = newPosition;
    }

}
