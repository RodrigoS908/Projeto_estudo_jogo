using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atack_katana : MonoBehaviour {
	public float speed;
	public float force;
	public bool isLeft;
	
	// Use this for initialization
	void Start () {
		Invoke("DestroyKatana", 7);
		

	}
	
	// Update is called once per frame
	void Update () {
		if(isLeft==true){
			transform.Translate(Vector2.left*Time.deltaTime*speed);
			transform.localScale = new Vector3(-1,1,1);

		}else{
			transform.Translate(Vector2.right*Time.deltaTime*speed);
			transform.localScale = new Vector3(1,1,1);
		}



	}



	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Enemies")
		{
			
			DestroyKatana();

		}
			
	
	}


	void DestroyKatana(){

		Destroy(this.gameObject);

	}
}
