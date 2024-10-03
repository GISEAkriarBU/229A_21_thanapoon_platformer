using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapons : MonoBehaviour
{
    [SerializeField] private int damage;
    public int Damage { get { return Damage; } set { Damage = value; } }
    public string Owner;

    
    public abstract void OnHitWith(Character character);
    public abstract void Move();
    public  int GetHitDirection(int hitD) {  return 1; }

}
