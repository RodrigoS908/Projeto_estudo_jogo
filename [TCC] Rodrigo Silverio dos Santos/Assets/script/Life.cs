using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour {
	public float timeLife;

	void SumirCoracao()
	{
		Destroy(this.gameObject);
	}
	void Start()
	{
		Invoke("SumirCoracao",timeLife);

	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player")
		{
			SumirCoracao();
		}
	}
}
