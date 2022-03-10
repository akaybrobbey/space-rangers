using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            GameControlScript.health += 1;
            Destroy(gameObject);

        }
        
    }
    
}
