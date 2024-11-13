using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : PlayerStats, DamageSystem
{
    [SerializeField] private Archer Marcus;
    private void Start()
    {
        Pounce();
        DamageSystem(Marcus.Attack);
    }

    protected override void Pounce()
    {
        Debug.Log("Archer got hit");
    }

    public void DamageSystem(int damage)
    {
        Debug.Log("Archer remaining HP: " + Health);
        Health -= damage;
        Debug.Log("Archer HP: " + Health);
        Debug.Log("~~~~~~~~~");
    }
}