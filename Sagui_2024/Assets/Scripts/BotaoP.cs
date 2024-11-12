using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotaoP : Button
{

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Pressionar();
    }

    void Pressionar()
    {
        if(IsPressed() == true)
        {
            player.GetComponent<Player>().Pular("pular");
        }
    }
}
