using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

public int Maxhits;
public int timeshit;
public Sprite[] hitsprite;
public AudioClip audioclip;

private LevelManager lvlmgr;
	// Use this for initialization
	void Start () {

	lvlmgr=GameObject.FindObjectOfType<LevelManager>();
		timeshit=0;
	}
	
	// Update is called once per frame
	void Update ()
	{
	}

	void LoadSprites ()
	{
	int spriteIndex=timeshit-1;
	this.GetComponent<SpriteRenderer>().sprite=hitsprite[spriteIndex];
	}

	void OnCollisionEnter2D(Collision2D other)
		{
		timeshit++;
		AudioSource.PlayClipAtPoint(audioclip,transform.position);
		if (timeshit >= Maxhits)
			Destroy (gameObject);
		else {
		LoadSprites();
		}
		}

}
