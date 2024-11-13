using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerStats : MonoBehaviour
{
    [SerializeField] protected int Health;
    [SerializeField] protected int Mana;
    public int Attack;
    [SerializeField] protected int Defense;
    [SerializeField] protected float Speed;
    [SerializeField] protected float Luck;

    protected abstract void Pounce();
}
