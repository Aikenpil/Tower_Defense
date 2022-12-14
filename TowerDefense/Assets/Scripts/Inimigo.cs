using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{

    [SerializeField] private int vida;

    void Start()
    {
        UnityEngine.AI.NavMeshAgent agente = GetComponent<UnityEngine.AI.NavMeshAgent>();
        GameObject fimDoCaminho = GameObject.Find("FimDoCaminho");
        Vector3 posicaoDoFimDoCaminho = fimDoCaminho.transform.position;
        agente.SetDestination(posicaoDoFimDoCaminho);
    }

    void Update()
    {

    }

    public void RecebeDano(int pontosDeDano)
    {
        vida -= pontosDeDano;
        if (vida <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}