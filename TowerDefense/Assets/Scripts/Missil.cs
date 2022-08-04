using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missil : MonoBehaviour
{

    private float velocidade = 100f;
    private GameObject alvo;
    [SerializeField] private int pontosDeDano;


    private void Start()
    {
        alvo = GameObject.Find("Inimigo");
    }
    
    void Update()
    {
        Anda();

        if(alvo != null) AlteraDirecao();
        AutoDestroiDepoisDeSegundos(10);
    }
    
    private void AutoDestroiDepoisDeSegundos(float segundos)
    {
        Destroy(this.gameObject, segundos);
    }

    private void Anda()
    {
        Vector3 posicaoAtual = transform.position;
        Vector3 frente = transform.forward;
        Vector3 deslocamento = frente * velocidade * Time.deltaTime;
        transform.position = posicaoAtual + deslocamento;
    }
    private void AlteraDirecao()
    {
        Vector3 direcaoDoMissil = transform.position;
        Vector3 direcaoDoInimigo = alvo.transform.position;
        Vector3 novaDirecao = direcaoDoInimigo - direcaoDoMissil;
        transform.rotation = Quaternion.LookRotation(novaDirecao);
    }
    void OnTriggerEnter(Collider elementoColidido)
    {
        if (elementoColidido.CompareTag("inimigo"))
        {
            Destroy(this.gameObject);
            Inimigo inimigo = elementoColidido.GetComponent<Inimigo>();
            inimigo.RecebeDano(pontosDeDano);
        }

    }
}
