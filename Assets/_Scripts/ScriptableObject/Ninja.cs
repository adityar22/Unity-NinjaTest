using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Ninja", menuName ="Scriptable/Ninja")]
public class Ninja : ScriptableObject
{
    public float HP;

    public float AttackCooldown;
    public float ThrowCooldown;

    public GameObject ThrowableItem;
}
