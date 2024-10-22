using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animals
{
    private void Awake()
    {
      InnitializeAnimal(100, "Dog");
    }
    private void Start()
    {
        MakeSound();
        Attack();
        TakeDamage(atteckingAnimal);
    }

    public override void MakeSound()
    { Debug.Log($" Bark Bark Bark by {animalName} "); }
    
    public override int GetRandomDamage()
    { return Random.Range( 1,50 ) + 5; }
    
    public override void Attack()
    {
        base.Attack();
        Debug.Log($" {animalName} is biting ");
    }
}
