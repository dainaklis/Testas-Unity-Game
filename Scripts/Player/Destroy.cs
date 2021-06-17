using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D col) 
    {
        if (col.gameObject.tag == "Player2")
        {
            Destroy(col.gameObject);
        }

        else if (col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
        }

        else if (col.gameObject.tag == "bullet")
        {
            // Destroy(col.gameObject);
            //Debug.Log("Bullet Pataiko i Wall");
        }


    }

}
