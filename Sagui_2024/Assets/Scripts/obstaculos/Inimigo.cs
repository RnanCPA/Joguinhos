using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    private GameController gc;
    private Animator anim;
    public float Speed;

    public bool parado = false;

    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        if (gc.GameLigado == true)
        {
            Mover();
        }
        AnimController();
    }

    public void Mover()
    {
        if(parado == false)
        {
            Vector2 NewPos = new Vector2(transform.position.x - 1f, transform.position.y);

            transform.position = Vector2.MoveTowards(transform.position, NewPos, Time.fixedDeltaTime * Speed * gc.AllSpeed);
        }
        if(parado == true)
        {
            Vector2 NewPos = new Vector2(transform.position.x - 1f, transform.position.y);

            transform.position = Vector2.MoveTowards(transform.position, NewPos, Time.fixedDeltaTime * Speed);
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

}
