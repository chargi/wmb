using UnityEngine;
using UnityEngine.UI; // we need this namespace in order to access UI elements within our script
using System.Collections;
using UnityEngineInternal;


public class menu : MonoBehaviour 
{
	public Button startText;
	public Button controlsText;
	public Button creditsText;
	public Button exitText;
	public Canvas cred;
	public Canvas controls;

	void Start () {
		startText = startText.GetComponent<Button> ();
		controlsText = controlsText.GetComponent<Button> ();
		creditsText = creditsText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		cred = cred.GetComponent<Canvas> ();
		cred.gameObject.SetActive (false);
		controls = controls.GetComponent<Canvas> ();
		controls.gameObject.SetActive (false);
	}

	void OnGUI () {

	}

	//this function will be used on our Play button
	public void StartLevel () {
		Application.LoadLevel (1); //this will load our first level from our build settings. "1" is the second scene in our game	
	}

	public void Credits () {
		if (!cred.gameObject.activeSelf) {
			if (controls.gameObject.activeSelf) {
				controls.gameObject.SetActive (false);
			}
			cred.gameObject.SetActive (true);
		} else {
			cred.gameObject.SetActive (false);
		}
	}

	public void Controls () {
		if (!controls.gameObject.activeSelf) {
			if (cred.gameObject.activeSelf) {
				cred.gameObject.SetActive (false);
			}
			controls.gameObject.SetActive (true);
		} else {
			controls.gameObject.SetActive (false);
		}
	}
	
	public void ExitGame () {
		Application.Quit(); //this will quit our game. Note this will only work after building the game
	}
	
}