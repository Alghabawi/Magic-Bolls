using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish3 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D ohter)
    {

        if (ohter.gameObject.CompareTag("playir") && ball.bol == 3) { Destroy(gameObject); }
    }
}
