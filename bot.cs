using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bot : MonoBehaviour
{
    public GameObject one ;
    public GameObject tue;

    // Start is called before the first frame update
    void Start()
    {
        one.SetActive(true);
        tue.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void fol2() {
    
    one.SetActive(false);

        tue.SetActive(true);    
    
    }
    public void fol1()
    {

        one.SetActive(true);

        tue.SetActive(false);

    }

}
