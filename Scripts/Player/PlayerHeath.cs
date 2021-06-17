using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHeath : MonoBehaviour
{
    public static PlayerHeath inkeliame;

    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int currentHealth;
    public  HealthBar healthBar;
    private Animator animPlayer;

    [SerializeField] private GameObject player;


    // //----------ENEMYSPAWNER from ZOTOV----------------------
    // [SerializeField] private GameObject enemySpawn;
    // private float randX;
    // private Vector2 whereToSpawn;
    // [SerializeField] private float spawnRate;
    // private float nextSpawn = 0f;



    

    private void Awake() 
    {
        inkeliame = this;
    }
    void Start()
    {
        animPlayer = GetComponent<Animator>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    { 
        if (currentHealth == 0)
        {
            animPlayer.Play("PlayerDead");

            // SoundManager.PlaySound("dead");

            Destroy(player, 4f);

        } 
        // else if (Time.time > nextSpawn)
        // {
        //     nextSpawn = Time.time + spawnRate;
        //     randX = Random.Range(-10f, 0f);
        //     whereToSpawn = new Vector2( randX, transform.position.y);
        //     Instantiate(enemySpawn, whereToSpawn, Quaternion.identity); 
        // }

              
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
