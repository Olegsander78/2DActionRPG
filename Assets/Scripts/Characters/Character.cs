using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Character : MonoBehaviour, IDamagable
{
    public enum Team
    {
        Player,
        Enemy
    }

    public string DisplayName;
    public int CurHP;
    public int MaxHP;

    [SerializeField] protected Team team;

    [Header("Audio")]
    [SerializeField] protected AudioSource audioSource;
    [SerializeField] protected AudioClip hitSFX;

    public event UnityAction onTakeDamage;
    public event UnityAction onHeal;

    public virtual void TakeDamage(int damageToTake)
    {
        CurHP -= damageToTake;
        audioSource.PlayOneShot(hitSFX);

        onTakeDamage?.Invoke();

        if (CurHP <= 0)
            Die();
    }

    public virtual void Die()
    {
        
    }

    public Team GetTeam()
    {
        return team; 
    }

    public virtual void Heal(int healAmount)
    {
        CurHP += healAmount;

        if(CurHP>MaxHP)
            CurHP = MaxHP;

        onHeal?.Invoke();
    }
}
