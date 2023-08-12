using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Scene_of_menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{

		SceneManager.LoadScene("SampleScene");

		} if(Input.GetKeyDown(KeyCode.A))
		  {


				SceneManager.LoadScene("cj");


		}




	}

	
		

	








}
