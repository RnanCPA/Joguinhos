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
    public GameObject audio;
    public GameObject Contagem;

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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void CarregarJogo()
    {
        Contagem.SetActive(true);
        TelaPreta.SetActive(false);
        audio.SetActive(true);
    }

}
