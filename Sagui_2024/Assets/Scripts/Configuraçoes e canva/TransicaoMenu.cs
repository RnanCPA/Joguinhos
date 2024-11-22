using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class TransicaoMenu : MonoBehaviour
{

    private GameController gc;

    public GameObject TelaPreta;
    public GameObject TelaJogo;
    public GameObject audio;
    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MudarCena()
    {
        SceneManager.LoadScene(1);
    }

    public void CarregarJogo()
    {
        TelaJogo.SetActive(true);
        TelaPreta.SetActive(false);
        audio.SetActive(true);
        gc.GameLigado = true;
    }

}
