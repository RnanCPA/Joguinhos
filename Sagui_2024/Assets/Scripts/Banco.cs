using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banco : MonoBehaviour
{
    public float meuCaixa;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        meuCaixa = PlayerPrefs.GetFloat("Moeda");
    }

    public void Comprar(int tipo)
    {
        float custo = 0;

        switch (tipo)
        {
            case 1:
                custo = 10;
                break;
            case 2:
                custo = 20; 
                break;
            case 3:
                custo = 30;
                break;
            default:
                custo = 0;
                break;
        }

        if(meuCaixa > 0)
        {
            meuCaixa = meuCaixa - custo;
            PlayerPrefs.SetFloat("Moeda", meuCaixa);
            BotaoComprado(tipo);
        }
    }

    void BotaoComprado(int numeroBotao)
    {
        switch (numeroBotao)
        {
            case 1:
                PlayerPrefs.SetString("Botao1", "Comprado");
                break;
            case 2:
                PlayerPrefs.SetString("Botao2", "Comprado");
                break;
            case 3:
                PlayerPrefs.SetString("Botao3", "Comprado");
                break;
        }
    }

}
