using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class playerMove : MonoBehaviour {
	
	public float speed;

	public float maxJump;
	public float minjump;
	public Transform player;

	public Animator anim;

	public Transform sensor;
	public bool grounded;
	public LayerMask WhatIsGround;
	public Rigidbody2D rig;
	public GameObject katana;
	public atack_katana code;
	private AudioSource audio;
	public AudioClip hit;
	private bool canShoot = true;
	public life_enemie life;
	private bool canSpecialShoot=false;



	void Start () {
		anim = player.GetComponent<Animator>();
		audio = GetComponent<AudioSource>();
		InvokeRepeating("AttackSpecial",10f,10f);
		life = GameObject.Find("Enemy_0").GetComponent<life_enemie>();
		
	}
	
	// Update is called once per frame

	void Update () {
		Movement();
		Jump();
		Attack();
	}

	void Movement(){

		anim.SetFloat("Walk", Mathf.Abs(Input.GetAxis("Horizontal")));

		if(Input.GetAxis("Horizontal")>0){

			transform.Translate(Vector2.right * speed*Time.deltaTime);
			transform.localScale=new Vector3(1,1,1);
			code.isLeft = false;

		
		}

		if(Input.GetAxis("Horizontal")<0){

			transform.Translate(Vector2.left * speed*Time.deltaTime);
			transform.localScale=new Vector3(-1,1,1);
			code.isLeft = true;
		}
	}
	public void Jump(){

		grounded= Physics2D.OverlapCircle(sensor.position,0.2f, WhatIsGround);
		anim.SetBool("Jump",!grounded);
	
		if(Input.GetButtonDown("Jump") && grounded == true){
			rig.AddForce(Vector2.up*maxJump);
		}

		if(Input.GetButtonDown("Jump") && grounded == false){
			rig.AddForce(Vector2.down * minjump);
		}

	}

	void Attack(){

		if(Input.GetMouseButtonDown(0) ){

			Instantiate(katana,transform.position,transform.rotation);
			audio.PlayOneShot(hit);
			
		}
		if(Input.GetMouseButtonDown(1) && canSpecialShoot == true){

			Instantiate(katana,transform.position,transform.rotation);
			Instantiate(katana,transform.position + new Vector3(2,0.15f,0),transform.rotation);
			Instantiate(katana,transform.position + new Vector3(4,0.30f,0),transform.rotation);
			Instantiate(katana,transform.position + new Vector3(6,0.45f,0),transform.rotation);
			Instantiate(katana,transform.position + new Vector3(8,0.50f,0),transform.rotation);
			life.RecebeDano(1000);
			audio.PlayOneShot(hit);
			audio.PlayOneShot(hit);
			audio.PlayOneShot(hit);
			audio.PlayOneShot(hit);
			audio.PlayOneShot(hit);
			audio.PlayOneShot(hit);
			audio.PlayOneShot(hit);
			audio.PlayOneShot(hit);
			audio.PlayOneShot(hit);
			audio.PlayOneShot(hit);
			canSpecialShoot = false;
		}





	}



	void AttackSpecial(){


		canSpecialShoot=true;

	}


		






} 



