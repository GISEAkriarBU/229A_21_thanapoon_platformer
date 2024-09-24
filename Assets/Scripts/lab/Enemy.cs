using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;
/// <summary>
/// abstract class
/// </summary>
public abstract class Enemy : Character
{
    private int damagehit;
    public int DamageHit { get { return damagehit; } set { damagehit = value; } }

    public abstract void Behaviour();


    private void start() { Behaviour(); }
}
