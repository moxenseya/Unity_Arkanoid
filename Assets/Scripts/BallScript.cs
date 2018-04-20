using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour {


Rigidbody2D rb;
private Paddle_Script paddle;
bool hasstarted;
private Vector3 PaddletoBallVector;
AudioSource audiosource;

	// Use this for initialization
	void Start () {
	hasstarted=false;
	paddle=GameObject.FindObjectOfType<Paddle_Script>();
	audiosource=GameObject.FindObjectOfType<AudioSource>();
	PaddletoBallVector= this.transform.position-paddle.transform.position;
	rb=GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		

		if (Input.GetMouseButtonDown (0)) {
		hasstarted=true;
		rb.velocity=new Vector2(Random.Range(-12,12),12f);
		}
		if(hasstarted==false)
		this.transform.position = paddle.transform.position + PaddletoBallVector;

		}

		void OnCollisionEnter2D (Collision2D other)
	{
	audiosource.Play();
	}


}
