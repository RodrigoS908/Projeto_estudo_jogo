using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour {

	
	public void YouWin(){

		Invoke("NextScene", 3);

	}

	void NextScene(){

		SceneManager.LoadScene("You_Win");

	}
}
