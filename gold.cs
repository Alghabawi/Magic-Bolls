using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gold : MonoBehaviour
{
    public AudioSource sounde;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("playir"))
        {
            sounde.Play();
            textgold.altin1 += 1;

            Destroy(gameObject);
            if (textgold.altin1 == 10)
            {

                textgold.altin1 = 0;
                heart.hart += 1;
            }
        }


    }
}
