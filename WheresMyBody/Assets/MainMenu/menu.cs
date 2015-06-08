﻿using UnityEngine;
using UnityEngine.UI; // we need this namespace in order to access UI elements within our script
using System.Collections;

public class menu : MonoBehaviour 
{
	public Button startText;
	public Button exitText;
	
	void Start ()
		
	{
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
	}

	
	public void StartLevel () //this function will be used on our Play button
		
	{
		Application.LoadLevel (1); //this will load our first level from our build settings. "1" is the second scene in our game	
	}
	
	public void ExitGame ()
		
	{
		Application.Quit(); //this will quit our game. Note this will only work after building the game
	}
	
}