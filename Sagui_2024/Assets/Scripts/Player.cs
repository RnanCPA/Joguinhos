using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameController gc;
    private Animator anim;
    private Animation Animation;
    Rigidbody2D rb;

    public float JumpForce;
    public bool PodePular = true;

    public float moedas = 0;


    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        AnimController();

    }


    public void Pular(string acao)
    {
        if(acao == "pular")
        {
            if(gc.GameLigado == true)
            {
                if (PodePular == true)
                {
                    PodePular = false;
                    rb.velocity = new Vector2(rb.velocity.x, JumpForce);
                }
            }
        }
    }

    public void AnimController()
    {
        if (gc.GameLigado == false)
        {
            anim.speed = 0;
        }
        if (gc.GameLigado == true)
        {
            anim.speed = 1;
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
        if (colisao.gameObject.tag == "Inimigo")
        {
            Destroy(colisao.gameObject);
            gc.Vidas--;
            if (gc.Vidas <= 0)
            {
                gc.GameOver();
            }
        }
    }

}
