using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class life_enemie : MonoBehaviour {
	public float vidaMax=3000;
	public float vidaAtual=3000;
	public SwitchScene switchScene;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.tag=="Katana")
			vidaAtual -=0.25f;
			if(vidaAtual <=0)
			{
			    SceneManager.LoadScene("You_Win");
				Destroy(this.gameObject);

			}
	
	}

	public void RecebeDano(float dano)
	{
		vidaAtual -= dano;
	}



	
}




