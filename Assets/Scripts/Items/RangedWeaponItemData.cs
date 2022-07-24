using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ranged Weapon Item Data", menuName = "Items/New Ranged Weapon Item Data")]
public class RangedWeaponItemData : ItemData
{
    [Header("Ranged Weapon Item Data")]
    public float FireRate;
    public GameObject ProjectilePrefab;
    public ItemData ProjectileItemData;

    public void Fire(Vector3 spawnPosition, Quaternion spawnRotation, Character.Team team)
    {
        GameObject proj = Instantiate(ProjectilePrefab, spawnPosition, spawnRotation);
        proj.GetComponent<Projectile>().SetTeam(team);
    }
}
