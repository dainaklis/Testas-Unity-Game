using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletDestroy : MonoBehaviour
{
    public GameObject blood;
    [SerializeField] private GameObject bloodPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collider) 
    {
        if (collider.gameObject.tag == "wall")
        {
            Destroy(gameObject);
        }

        if (collider.gameObject.tag == "Player2")
        {
            //Instantiate(blood);
            Instantiate(bloodPlayer, transform.position, Quaternion.identity);
            Destroy(gameObject);
            // Destroy(collider.gameObject);
            //Debug.Log("Hit Player2 !!!!");
            SoundManager.PlaySound("hit1");

            Player2Heath.inkeliame2.TakeDamage(20);
            
        }
        
    }
}
