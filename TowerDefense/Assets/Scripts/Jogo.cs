using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogo : MonoBehaviour
{
	[SerializeField] private GameObject torrePrefab;
	[SerializeField] private GameObject gameOver;
	[SerializeField] private GameObject Restart;
	[SerializeField] private DadosdoJogador jogador;

	void Start()
	{
		gameOver.SetActive(false);
		Restart.SetActive(false);
	}

	void Update()
	{
		if (JogoAcabou())
		{
			gameOver.SetActive(true);
			Restart.SetActive(true);
			Time.timeScale = 0;
		}
		else
		{
			if (Clicou())
			{
				CriaTorre();
			}
		}
    }

    private bool JogoAcabou()
    {
        return !jogador.EstaVivo();
    }

    private bool Clicou()
	{
		return Input.GetMouseButtonDown(0); //0 é esquerda, 1 direita, 2 central
	}

	public void RecomecaJogo()
	{
		Application.LoadLevel(Application.loadedLevel);
	}

	private void CriaTorre()
	{
		//criar torre
		Vector3 pontoDoClique = Input.mousePosition;

		Ray raioDaCamera = Camera.main.ScreenPointToRay(pontoDoClique);
		RaycastHit infoDoRaio;
		float comprimentoMaximo = 1000f;
		Physics.Raycast(raioDaCamera, out infoDoRaio, comprimentoMaximo);

		if (infoDoRaio.collider)
		{
			Vector3 posicao = infoDoRaio.point;
			Instantiate(torrePrefab, posicao, Quaternion.identity);
		}
	}
}
