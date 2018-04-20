using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class NumberWizard : MonoBehaviour {
	// Use this for initialization
	int max;
	int min;
	int guess;
	public Text text;
	int maxGuessesAllowed=10;
	void Start () {
		StartGame();
	}
	
	void StartGame () {
		max = 1000;
		min = 1;
		guess = Random.Range(min,max);
		text.text="Is the number: " + guess.ToString() + " ?";
		max = max + 1;
		

	}

	public void GuessHigher()
	{
		min = guess;
			NextGuess();
	
	}
	public void GuessLower ()
	{
		max = guess;
			NextGuess();
	}

	void NextGuess ()
	{
		guess = Random.Range(min,max);
		maxGuessesAllowed--;
		text.text = "Is the number: " + guess.ToString() + " ?";
		if (maxGuessesAllowed <= 0) {
		SceneManager.LoadScene("WinScene");
		}
			}
}
