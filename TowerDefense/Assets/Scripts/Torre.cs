using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour
{
    public GameObject prefabDoMissil;
    void Start()
    {
        GameObject pontoDeDisparo = GameObject.Find("Canhao/PontoDeDisparo");
        Vector3 posicaoDoPontoDeDisparo = pontoDeDisparo.transform.position;
        Instantiate(prefabDoMissil, posicaoDoPontoDeDisparo, transform.rotation);
    }
}
