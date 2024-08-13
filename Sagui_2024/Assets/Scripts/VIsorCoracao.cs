using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;

public class VIsorCoracao : MonoBehaviour
{
    private GameController gc;
    private RectTransform rtImagem;

    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").
                GetComponent<GameController>();
        rtImagem = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        float TamanhoAjustado = gc.Vidas * 100;
        rtImagem.sizeDelta = new Vector2(TamanhoAjustado, 100);
    }
}
