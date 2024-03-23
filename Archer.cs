using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Adventurer
{
    public override void Attack()
    {
        base.Attack();
        Debug.Log("1st Job: Archer");
    }
}
