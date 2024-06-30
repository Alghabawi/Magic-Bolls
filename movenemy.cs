using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movenemy : MonoBehaviour
{
    public Transform a, b;
    public float sped = 5;
    Vector2 terget;
    int x = 0;
    void Start()
    {
        terget = b.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, a.position) < .1f)
        {
            terget = b.position;
            gameObject.transform.localScale = new Vector3(-2.59115f, 2.227046f, 1);

        }
        if (Vector2.Distance(transform.position, b.position) < .1f)
        {
            terget = a.position;

            gameObject.transform.localScale = new Vector3(2.59115f, 2.227046f, 1);

        }
        transform.position = Vector2.MoveTowards(transform.position, terget, sped * Time.deltaTime);

    }
}
