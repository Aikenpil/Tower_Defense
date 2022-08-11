using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowLife : MonoBehaviour
{
	[SerializeField] TMP_Text campoTexto;
	[SerializeField] DadosdoJogador jogador;

	void Update()
	{
		campoTexto.text = "Vida:" + jogador.GetVida();
	}
}
