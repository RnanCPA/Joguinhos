using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VisorMoedas : MonoBehaviour
{

    private Player pl;
    private TMP_Text meuTexto;

    // Start is called before the first frame update
    void Start()
    {
        pl = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        meuTexto = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        meuTexto.text = ": " + pl.moedas.ToString();
    }
}
