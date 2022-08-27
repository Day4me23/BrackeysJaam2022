using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDayne : MonoBehaviour
{
    public float maxHealth = 20;
    public float currentHealth;
    public HealthBar healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void Update()
    {
        currentHealth -= Time.deltaTime;
        healthBar.SetHealth(currentHealth);
    }
}
