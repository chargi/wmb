using UnityEngine;
using System.Collections;

/*
 * Script that handles the palyer inventory (currently only keys)
 */
public class Inventory : MonoBehaviour {
	private bool hasKey=false;
	public Texture keytex;
	public GameObject key;
	public GameObject player;
	public GameObject fencedoor;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.E) && Vector3.Distance(key.transform.position, player.transform.position)<10 &&!hasKey){
			key.transform.position=new Vector3(60,-5,-120);
			ToggleKeys();
		}
		if(Input.GetKeyDown(KeyCode.E) && Vector3.Distance(fencedoor.transform.position, player.transform.position)<15 && hasKey){
			ToggleKeys();
			fencedoor.GetComponent<Fencedoor>().OpenDoor();
		}
	}

	void OnGUI() {
		if(hasKey)
			GUI.DrawTexture(new Rect(Screen.width-100,Screen.height-100,60, 60), keytex, ScaleMode.ScaleToFit, true, 0 );
	}

	public void ToggleKeys(){
		hasKey=!hasKey;
	}

	public bool GetKey(){
		return hasKey;
	}
}
