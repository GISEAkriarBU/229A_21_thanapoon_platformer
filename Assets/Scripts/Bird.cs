using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animals
{
    private void Awake()
    {
        InnitializeAnimal(100, "Angry Bird");
    }
    private void Start()
    {
        MakeSound();
        Attack();
        TakeDamage(atteckingAnimal);
    }
    public override void MakeSound() 
    { Debug.Log($"chirp chirp by {animalName}  "); }
    public override int GetRandomDamage()
    { return Random.Range(10, 50) * 2; }
    public override void Attack()
    {
        base.Attack();
        Debug.Log($" {animalName} is pecking ");
    }
}
