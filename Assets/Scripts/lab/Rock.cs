using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Rock : Weapons

{
    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] private Vector2 force;

    void Start()
    {
        force = new Vector2(GetShootDirection() * 100, 400);
        Move();

    }
    
    public override void OnHitWith(Character character) { if (character is Player) { character.TakeDamage(this.Damage); }}
    public override void Move() { rb2d.AddForce (force, ForceMode2D.Force); }
}
