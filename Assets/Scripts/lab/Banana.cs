using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapons
{
    
    private void Start()
    {

        Move();
    }

    [SerializeField]  private float speed ;
    public override void OnHitWith(Character enemy) { }
    public override void Move() { Debug.Log($" object {name} TARNSFORM WITH speed ({speed})  "); }
 
}
