using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update
    Text text2;
    public static int bol;

    void Start()
    {
        text2 = GetComponent<Text>();
    }


    // Update is called once per frame
    public void Update()
    {
        text2.text = ":" + bol;
        

    }
    
}
