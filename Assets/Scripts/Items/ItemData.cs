using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item Data", menuName = "Items/New Item")]
public class ItemData : ScriptableObject
{
    public string DisplayName;
    public string Descrition;
    public Sprite Icon;

    public int MaxStackSize = 1;

    public GameObject EquipPrefab;
}
