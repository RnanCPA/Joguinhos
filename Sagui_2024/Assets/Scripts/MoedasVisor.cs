using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoedasVisor : MonoBehaviour
{
    private GameController gc;
    private TMP_Text meuTexto;

    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        meuTexto = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        meuTexto.text = gc.moedas.ToString();
    }
}
