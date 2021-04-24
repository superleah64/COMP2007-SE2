using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSystem : MonoBehaviour
{
    // sets max health as 100
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        // takes 10 damage when left arrow key is pressed
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            TakeDamage(10);
        }

        // gains 10 health when right arrow is pressed
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GainHealth(10);
        }

        // health bar turns red if health is below 30
        if (currentHealth == 30)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }

    // sets damage variable as the current health minus the damage taken
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    // sets health variable as the current health plus the health gained
    void GainHealth(int health)
    {
        currentHealth += health;
        healthBar.SetHealth(currentHealth);
    }
}