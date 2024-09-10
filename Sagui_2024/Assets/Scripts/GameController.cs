using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public bool GameLigado = true;
    public float Vidas = 3;
    public float moedas = 0;

    public GameObject TelaJogo;
    public GameObject TelaPause;
    public GameObject TelaOver;
    public GameObject TelaFinish;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IniciarJogo()
    {
        SceneManager.LoadScene(1);
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void FecharJogo()
    {
        Application.Quit();
    }

    public void Pausar()
    {
        TelaJogo.SetActive(false);
        GameLigado = false;
        TelaPause.SetActive(true);
    }

    public void DesPausar()
    {
        TelaPause.SetActive(false);
        GameLigado = true;
        TelaJogo.SetActive(true);
    }

    public void MenuInicial()
    {
        SceneManager.LoadScene(0);
    }

    public void GameOver()
    {
        TelaJogo.SetActive(false);
        GameLigado = false;
        TelaOver.SetActive(true);
    }

    public void TerminarFase()
    {
        TelaJogo.SetActive(false);
        GameLigado = false;
        TelaFinish.SetActive(true);
    }

}
