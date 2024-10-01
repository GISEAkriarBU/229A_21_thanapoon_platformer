using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocodile : Enemy
{
    private float attackRangr;
    private Player player;

    public void Start()
    {
        Init(100);
        Debug.Log($"{Health}");
        Behaviour();
    }

    public override void Behaviour()
    {
        Debug.Log("Croccodile ");
    }

}
