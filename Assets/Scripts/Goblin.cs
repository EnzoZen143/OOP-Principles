using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : NPCStats, DamageSystem
{
    [SerializeField] private Goblin Jojo;
    private void Start()
    {
        Pounce();
        DamageSystem(Jojo.Attack);
    }

    protected override void Pounce()
    {
        Debug.Log("Goblin got hit");
    }

    public void DamageSystem(int damage)
    {
        Debug.Log("Goblin remaining HP: " + Health);
        Health -= damage;
        Debug.Log("Goblin HP: " + Health);
        Debug.Log("~~~~~~~~~");
    }
}
