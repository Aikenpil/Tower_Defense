using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectordeChegada : MonoBehaviour
{
	[SerializeField] private DadosdoJogador jogador;

	private void OnTriggerEnter(Collider collider)
	{
		if (collider.CompareTag("inimigo"))
		{
			Debug.Log("Tomaste dano");
			Destroy(collider.gameObject);
			jogador.PerdeVida();
		}
	}
}
