var pauseMenuFont : Font;
protected var pauseEnabled = false;			
var customGuiStyle : GUIStyle;

function Start(){
	pauseEnabled = false;
	Time.timeScale = 1;
	AudioListener.volume = 1;
	Cursor.visible = false;
}

function Update(){

	//check if pause button (escape key) is pressed
	if (Input.GetKeyDown("escape")) {
	
		//check if game is already paused		
		if (pauseEnabled == true) {
			//unpause the game
			pauseEnabled = false;
			Time.timeScale = 1;
			AudioListener.volume = 1;
			Cursor.visible = false;	
		}
		
		//else if game isn't paused, then pause it
		else if (pauseEnabled == false) {
			pauseEnabled = true;
			AudioListener.volume = 0;
			Time.timeScale = 0;
			Cursor.visible = true;
		}
	}
}

function OnGUI() {

	GUI.skin.box.font = pauseMenuFont;
	GUI.skin.button.font = pauseMenuFont;

	if (pauseEnabled == true) {
		
		//Make a background box		
		GUI.Box(Rect(Screen.width /2 - 100,Screen.height /2 - 50,250,200), "Pause Menu", customGuiStyle);
		
		//Make Main Menu button
		if(GUI.Button(Rect(Screen.width /2 - 100,Screen.height /2 ,250,50), "Main Menu")) {
			Application.LoadLevel(0);
		}
		
		//Make Restart Level Button
		if(GUI.Button(Rect(Screen.width /2 - 100,Screen.height /2 +50,250,50), "Restart Level")) {
			Application.LoadLevel(Application.loadedLevel);
		}

		//Make quit game button
		if (GUI.Button(Rect(Screen.width /2 - 100,Screen.height /2 +100,250,50), "Quit Game")) {
			Application.Quit();
		}
	}
}