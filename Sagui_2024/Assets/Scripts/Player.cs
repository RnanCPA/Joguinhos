using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameController gc;
    private Animator anim;
    Rigidbody2D rb;

    public float JumpForce;
    bool PodePular = true;

    public float moedas = 0;


    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gc.GameLigado == true)
        {
            Pular();
            Pause();
        }
    }

    public void Pular()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(PodePular == true)
            {
                PodePular = false;
                rb.velocity = new Vector2(rb.velocity.x, JumpForce);
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Piso")
        {
            PodePular = true;
        }

        if(collision.gameObject.tag == "Inimigo")
        {
            Destroy(collision.gameObject);
            gc.Vidas--;
            if(gc.Vidas <= 0)
            {
                gc.GameOver();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D colisao)
    {
        if(colisao.gameObject.tag == "Moeda")
        {
            moedas++;
            Destroy(colisao.gameObject);
        }

        if(colisao.gameObject.tag == "Vida")
        {
            if(gc.Vidas < 3)
            {
                gc.Vidas++;
            }
            Destroy(colisao.gameObject);
        }

    }

    public void Pause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gc.Pausar();
        }
    }

}
