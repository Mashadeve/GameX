using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int maxHealth = 100;
    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }


    public void Die(int damage)
    {
        currentHealth -= damage;
    }

    private void Update()
    {
        if (currentHealth == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
