using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IceBulletDestroy : MonoBehaviour
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

        if (collider.gameObject.tag == "Player")
        {
            //Instantiate(blood);
            Instantiate(bloodPlayer, transform.position, Quaternion.identity);
            Destroy(gameObject);
            // Destroy(collider.gameObject);
            //Debug.Log("Hit Player !!!!");

            SoundManager.PlaySound("hit2");

            //Debug.Log("Live - 20 !!!!!");

            PlayerHeath.inkeliame.TakeDamage(20);

            


        }
        
    }


}
