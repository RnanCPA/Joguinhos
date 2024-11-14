using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuOpcoes : Button
{
    private GameController gc;

    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        Pressionar();
    }

    public void Pressionar()
    {
        if(IsPressed() == true)
        {
            gc.GameLigado = true;
            Time.timeScale = 1;
        }
    }
}
