using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    private GameController gc;

    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gc.GameLigado == true)
        {
            Mover();
        }
    }

    public void Mover()
    {
        Vector2 NewPos = new Vector2(transform.position.x - 1f, transform.position.y);

        transform.position = Vector2.MoveTowards(transform.position, NewPos, Speed);
    }

}
