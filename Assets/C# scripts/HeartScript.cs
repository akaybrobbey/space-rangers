using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D col)
    {
        GameControlScript.health += 1;
        Destroy(gameObject);
    }
}
