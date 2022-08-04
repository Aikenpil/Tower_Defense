using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.AI.NavMeshAgent agente = GetComponent<UnityEngine.AI.NavMeshAgent>();
        GameObject fimDoCaminho = GameObject.Find("FimDoCaminho");
        Vector3 posicaoDoFimDoCaminho = fimDoCaminho.transform.position;
        agente.SetDestination(posicaoDoFimDoCaminho);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}