using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapons

{
    
    private void Start()
    {
        
        Move();

    }
    
    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] private Vector2 force;

    public override void OnHitWith(Character enemy) { }
    public override void Move() { Debug.Log($" object {name} TARNSFORM WITH Force ({force})"); }
}
