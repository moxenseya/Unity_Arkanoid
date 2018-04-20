using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BottomEdge : MonoBehaviour {

private LevelManager lvlmgr;

	// Use this for initialization
	void Start () {
		lvlmgr= GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other)
	{
	if(other.gameObject.name=="ball")
	lvlmgr.LoadLevel("GameOver");
	}
}
