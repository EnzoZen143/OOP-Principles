using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPCStats : MonoBehaviour
{
    [SerializeField] protected int Health;
    public int Attack;
    [SerializeField] protected int Defense;
    [SerializeField] protected float Speed;

    protected abstract void Pounce();
}
