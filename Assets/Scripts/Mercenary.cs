using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercenary : NPCStats, DamageSystem
{
    [SerializeField] private Mercenary Santa;
    private void Start()
    {
        Pounce();
        DamageSystem(Santa.Attack);
    }

    protected override void Pounce()
    {
        Debug.Log("Mercenary got hit");
    }

    public void DamageSystem(int damage)
    {
        Debug.Log("Mercenary remaining HP: " + Health);
        Health -= damage;
        Debug.Log("Mercenary HP: " + Health);
        Debug.Log("~~~~~~~~~");
    }
}
