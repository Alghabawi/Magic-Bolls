using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class control : MonoBehaviour
{
    public GameObject level22;
    public GameObject blok2;
    public GameObject level33;
    public GameObject blok3;
    void Start()
    {
        level22.SetActive(false);
        blok2.SetActive(true);
        level33.SetActive(false);
        blok3.SetActive(true);
        if (ball.bol ==1)
        {
            level22.SetActive(true);
            blok2.SetActive(false);
        }
        if (ball.bol == 2)
        {
            level22.SetActive(true);
            blok2.SetActive(false);
            level33.SetActive(true);
            blok3.SetActive(false);
        }
        if (ball.bol == 3)
        {
            level22.SetActive(true);
            blok2.SetActive(false);
            level33.SetActive(true);
            blok3.SetActive(false);
        }
    }
    public void level1()
    {
        SceneManager.LoadScene(2);
        heart.hart = 1;
        textgold.altin1 = 0;
        tiam.StopTime = true;
    }
    public void leve()
    {
        SceneManager.LoadScene(0);
        tiam.StopTime = true;
    }
    public void level2()
    {
        SceneManager.LoadScene(3);
        heart.hart = 1;
        textgold.altin1 = 0;
        tiam.StopTime = true;
    }
    public void level3()
    {
        SceneManager.LoadScene(4);
        heart.hart = 1;
        textgold.altin1 = 0;
        tiam.StopTime = true;
    }
    public void home()
    {
        SceneManager.LoadScene(1);
        tiam.StopTime = true;
    }
    

    
}
