using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Animals : MonoBehaviour
{
    [SerializeField] protected Animals atteckingAnimal;
    protected string animalName = "";
    protected int damage;

    private int health;
    public int Health { get { return health; }
        set{ health = Mathf.Clamp(value, 0, 100); }}

    public abstract void MakeSound();
    public abstract int GetRandomDamage();
    public void InnitializeAnimal(int newHealth, string newName = "Animal")
    {
        Health = newHealth;
        animalName = newName;
        damage = GetRandomDamage();
        DisplayAnimalStatus();
    }

    public void DisplayAnimalStatus() 
    {
        Debug.Log($"{name} NAME {animalName}  status is in condition  {Health}  damage got {damage} ");
    }
    
    public void TakeDamage(Animals atkAnimal)
    {
        if (atkAnimal == null)
        {
            Debug.Log($" Animal(Null) is perform an atack ");
            return;
        }
        
        Debug.Log($" {atkAnimal.animalName} attacks  ");
        
        Health -= atkAnimal.damage;
        Debug.Log($" {animalName} took by{atteckingAnimal} with {atkAnimal.damage} damage REmain HP IS {Health}");
        
        if (IsDead() == true) 
        {
            Debug.Log($" {animalName} is dead ! ");
        }


    }

    public bool IsDead()
    {
       return Health <= 0;
    }

    public virtual void Attack() 
    {
        Debug.Log($" Animal is perform an atack ");
    }

}
