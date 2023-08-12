using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_movement : MonoBehaviour {
	public Transform playerPosition;
	public Transform enemyPosition;
	public float speed;
	private float originalSpeed;
	public float jump;
	public Rigidbody2D enemy;
	private float timejump;
	public float force_down;
	private float life;

	public LayerMask WhatIsGround;
	public bool grounded;
	public Transform sensor;
	
	

	// Use this for initialization
	void Start () {
		originalSpeed = speed;
	}
	
	// Update is called once per frame
	void Update () {
		life = GetComponent<life_enemie>().vidaAtual;
		if(grounded == true){


			if(playerPosition.position.x < enemyPosition.position.x){
				transform.Translate(Vector2.right*Time.deltaTime*speed);
				transform.localScale=new Vector3(1,1,1);
			}else{
				transform.Translate(Vector2.left*Time.deltaTime*speed);
				transform.localScale=new Vector3(-1,1,1);

			}

		}

		timejump = Random.Range(0,50);

		if(timejump == 3){

			Jump();

		}

		if (playerPosition.position.x == enemyPosition.position.x){

			enemy.AddForce(Vector2.down * force_down);


		}

		grounded = Physics2D.OverlapCircle(sensor.position,0.2f, WhatIsGround);
	}

	void Jump(){

		if(grounded == true){
			enemy.AddForce(Vector2.up * jump);

			if(playerPosition.position.x < enemyPosition.position.x){
				enemy.AddForce(Vector2.left * jump);
			}else{
				enemy.AddForce(Vector2.right * jump);

			}

			speed = 17;
			Invoke("ResetSpeed",2);
		}

	}

	void ResetSpeed(){

		speed = originalSpeed;

	}








}
