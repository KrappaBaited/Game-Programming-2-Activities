using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barbarian : Swordsman
{
    public override void Attack()
    {
        base.Attack();
        Debug.Log("2nd Job: Barbarian");
    }
}
