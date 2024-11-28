using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contagem : MonoBehaviour
{
    private GameController gc;

    public GameObject TelaContagem;
    public GameObject TelaJogo;
    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ComecarJogo()
    {
        TelaContagem.SetActive(false);
        TelaJogo.SetActive(true);
        gc.GameLigado = true;
    }
}
