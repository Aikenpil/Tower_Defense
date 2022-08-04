using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour
{

    private float momentoDoUltimoDisparo;
    public float tempoDeRecarga = 1f;
    public GameObject prefabDoMissil;
    private GameObject alvo;

    private void Start()
    {
        alvo = GameObject.Find("Inimigo");
    }

    private void Update()
    {
        if (alvo != null) Atira();
    }

    private void Atira()
    {
        float tempoAtual = Time.time;
        if (tempoAtual > momentoDoUltimoDisparo + tempoDeRecarga)
        {
            momentoDoUltimoDisparo = tempoAtual;
            GameObject pontoDeDisparo = GameObject.Find("Canhao/PontoDeDisparo");
            Vector3 posicaoDoPontoDeDisparo = pontoDeDisparo.transform.position;
            Instantiate(prefabDoMissil, posicaoDoPontoDeDisparo, transform.rotation);
        }

    }
}