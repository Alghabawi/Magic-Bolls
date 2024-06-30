using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balls : MonoBehaviour
{
    public Animator door1;
 
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("playir"))
        {
            ball.bol += 1;
            door1.SetBool("door1", true);
            Destroy(gameObject);
        }


    }
}
