using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Melee Weapon Item Data", menuName = "Items/New Melee Weapon Item Data")]
public class MeleeWeaponItemData : ItemData
{
    [Header("Malee Weapon Item Data")]
    public int Damage;
    public float Range;
    public float AttackRate;
}
