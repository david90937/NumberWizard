using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	public int guess;
	public int MaxGuessesAllowed = 10;
	public Text text;
	// Use this for initialization
	void Start () {
		StartGame();


	}

	void StartGame (){ 

	max = 5000;
	min = 1;
	guess = 500;

		text.text = "Is the number higher or lower than " + guess + "?\n\n" +
		"Up arrow for higher, down for lower, or return for equals";

		print("Welcome to NumberWizard!");
		print("Pick a number in your head, but don't tell me.");

		print("The highest number you can pick is " + max);
		print("The lowest number you can pick is " + min);

		print("Is the number higher or lower than " + guess + "?");
		print("Up arrow for higher, down for lower, or return for equals");

		max = max +1;
	}
	public void Lower() 
	{
		max = guess;
		NextGuess (); 
	}

	public void Higher() 
	{
		min = guess;
		NextGuess(); 
	}

	void NextGuess()
	{
		guess = Random.Range(min, max);
		MaxGuessesAllowed = (MaxGuessesAllowed - 1);
		text.text = guess.ToString();
		print ("Is the number higher or lower than " + guess + "?");
		if (MaxGuessesAllowed <= 0) {	
			Application.LoadLevel("Win"); }
	}


	
	// Update is called once per frame
	void Update ()
	{

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");
			StartGame();
		}
	}
}
