using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class life_player : MonoBehaviour {



	public float VidaMax=1000;
	public float VidaAtual=1000;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionStay2D(Collision2D collision)
	{
			if(collision.gameObject.tag=="Enemies"){

				VidaAtual -=100;

				if (VidaAtual <=0)
				{
					SceneManager.LoadScene("Game_Over");

				}
			}


	
	}

		
}

