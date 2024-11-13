using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordsman : PlayerStats, DamageSystem
{
    [SerializeField] private Swordsman Enzo;
    private void Start()
    {
        Pounce();
        DamageSystem(Enzo.Attack);
    }

    protected override void Pounce()
    {
        Debug.Log("Swordsman got hit");
    }

    public void DamageSystem(int damage)
    {
        Debug.Log("Swordsman remaining HP: " + Health);
        Health -= damage;
        Debug.Log("Swordsman HP: " + Health);
        Debug.Log("~~~~~~~~~");
    }
}
