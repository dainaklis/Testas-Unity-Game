using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScripts : MonoBehaviour
{
    //----------ENEMYSPAWNER from ZOTOV----------------------
    [SerializeField] private GameObject enemySpawn;
    private float randX;
    private Vector2 whereToSpawn;
    [SerializeField] private float spawnRate;
    private float nextSpawn = 0f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-10f, 0f);
            whereToSpawn = new Vector2( randX, transform.position.y);
            Instantiate(enemySpawn, whereToSpawn, Quaternion.identity); 
        }
    }
}
