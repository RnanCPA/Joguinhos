using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.IK;
using UnityEngine.SceneManagement;

public class PassarFase : MonoBehaviour
{

    public float AvancarFase;
    public float Contador;
    public int _fase;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Contador += Time.deltaTime;

        if (Contador > 2)
        {
            AvancarFase++;
            Contador = 0;
        }


        if(AvancarFase > 120)
        {
            ProxFase();
        }
    }

    void ProxFase()
    {
        if(_fase == 1)
        {
            SceneManager.LoadScene(2);
        }
        if (_fase == 2)
        {
            SceneManager.LoadScene(3);
        }
        if (_fase == 3)
        {
            SceneManager.LoadScene(1);
        }
    }
}
