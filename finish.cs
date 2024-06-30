using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class finish : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D ohter)
    {
       
        if (ohter.gameObject.CompareTag("playir")&& ball.bol==1 ) { Destroy(gameObject); }
    }
}
