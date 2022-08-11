using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DadosdoJogador : MonoBehaviour
{
	[SerializeField] private int vida = 10;

	public int GetVida()
	{
		return vida;
	}

	public void PerdeVida()
	{
		if (EstaVivo())
		{
			vida--;
		}
	}

	public bool EstaVivo()
	{
		return vida > 0;
	}
}
