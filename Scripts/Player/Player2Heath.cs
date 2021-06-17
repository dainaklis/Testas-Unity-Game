using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Heath : MonoBehaviour
{
    public static Player2Heath inkeliame2;

    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int currentHealth;
    public  HealthBar healthBar;

    [SerializeField] private GameObject player2;
    

    private void Awake() 
    {
        inkeliame2 = this;
    }
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    { 
        if (currentHealth == 0)
        {
            SoundManager.PlaySound("dead2");

            Destroy(player2, 4f);
        }  

              
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
