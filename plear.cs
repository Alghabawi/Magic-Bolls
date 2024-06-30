using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor;
//using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.UI;
public class plear : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    private float movee;
    public float seed = 8f;
    public float jump;
    private bool isjamping;

    public GameObject slmon;
    public GameObject gameovver;


    public GameObject winer;

    public Animator walik;
    public Animator jump1;
    public Animator die;
    public AudioSource jampmusic;
    public AudioSource deathmusic;
    public AudioSource wineermusic;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void Update()
    {
        movee = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(movee * seed, rb.velocity.y);
        if (movee > 0)
        {
            gameObject.transform.localScale = new Vector3(0.467281f, 0.4607433f, 0);
            walik.SetBool("idel", true);
        }
        else if (movee < 0)
        {
            gameObject.transform.localScale = new Vector3(-0.467281f, 0.4607433f, 0);
            walik.SetBool("idel", true);
        }
        else if (movee == 0)
        {
            walik.SetBool("idel", false);
        }


        if (Input.GetButtonDown("Jump") && !isjamping)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            isjamping = true;
            jampmusic.Play();
            jump1.SetBool("Jump", true);

        }

    }
    void OnCollisionEnter2D(Collision2D ohter)
    {
        if (ohter.gameObject.CompareTag("ground"))
        {
            isjamping = false;
            jump1.SetBool("Jump", false);

        }
        if (ohter.gameObject.CompareTag("enemy"))
        {
            heart.hart -= 1;
            gameObject.SetActive(false);
            die.SetBool("die", true);
            gameObject.transform.position = new Vector3(462.7869f, -8.336002f, 0);
            die.SetBool("die", false);
            gameObject.SetActive(true);


            if (heart.hart == 0)
            {
                deathmusic.Play();
               die.SetBool("die", true);
                gameObject.SetActive(false);
                Instantiate(slmon, transform.position, Quaternion.identity);
                Instantiate(gameovver, transform.position, Quaternion.identity);

            }

        }
        if (ohter.gameObject.CompareTag("kazan"))
        {
            gameObject.SetActive(false);
            Instantiate(winer, transform.position, Quaternion.identity);
            wineermusic.Play();
        }
    }
}
