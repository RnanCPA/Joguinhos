using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoCompra : MonoBehaviour
{

    public int numeroDoBotao;
    public GameObject botaoCompra;
    public GameObject botaoSeleciona;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string estadoAtual;
        switch (numeroDoBotao)
        {
            case 1:
                estadoAtual = PlayerPrefs.GetString("Botao1");
                if(estadoAtual == "Comprado")
                {
                    botaoCompra.SetActive(false);
                    botaoSeleciona.SetActive(true);
                }
                break;
                case 2:
                estadoAtual = PlayerPrefs.GetString("Botao2");
                if (estadoAtual == "Comprado")
                {
                    botaoCompra.SetActive(false);
                    botaoSeleciona.SetActive(true);
                }
                break;
                case 3:
                estadoAtual = PlayerPrefs.GetString("Botao3");
                if (estadoAtual == "Comprado")
                {
                    botaoCompra.SetActive(false);
                    botaoSeleciona.SetActive(true);
                }
                break;
        }
    }
}
