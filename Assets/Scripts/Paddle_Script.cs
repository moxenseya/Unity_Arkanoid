using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle_Script : MonoBehaviour {

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
float x=Input.mousePosition.x/Screen.width*16;		
this.transform.position=new Vector3(Mathf.Clamp(x,0.5f,15.5f),0.0f);
		}
}
