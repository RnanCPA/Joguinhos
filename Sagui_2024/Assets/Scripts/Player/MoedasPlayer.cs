using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoedasPlayer : MonoBehaviour
{
    private Player pl;
    private TMP_Text meuTexto;
    // Start is called before the first frame update
    void Start()
    {
        meuTexto = GetComponent<TMP_Text>();
        pl = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        meuTexto.text = pl.moedas.ToString();
    }
}
