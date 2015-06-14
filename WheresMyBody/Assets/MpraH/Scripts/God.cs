using UnityEngine;
using System.Collections;

/*
 * Script that is responsible for dying and respawning
 */
public class God : MonoBehaviour {
	//Goes up whenever the palyer dies
	private int life=0;
	private bool dying=false;
	private float turnSpeed=1f;
	//main first-person camera
	public Camera Cam1;
	//third person death camera
	public Camera Cam2;
	public GameObject FPSController;

	void Start(){
		Cam1.enabled=true;
		Cam2.enabled=false;
	}

	void Update(){
		if(Input.GetKeyDown(KeyCode.C)){
			Die ();
		}
		/*
		 * Moves the death camera and respawns the player
		 */
		if(dying){
			if(Cam2.transform.localPosition.y <8){
				Cam2.transform.Rotate(new Vector3(120/8,0,0),turnSpeed*10*Time.deltaTime);
				Cam2.transform.Translate(new Vector3(0,1,-6/8)*turnSpeed*Time.deltaTime);
			}else{
				dying=false;
				Respawn();
			}
		}
	}	
	/*
	 * Kills the player
	 */ 
	public void Die(){
		ChangeCamera();
		dying=true;
	}

	/*
	 * Respawns the player
	 */ 
	public void Respawn(){
		life++;
		FPSController.transform.position=new Vector3(0-4*life,1,-103);
		Destroy(GameObject.Find("Player_inactive_"+life));
		ChangeCamera();
		Cam2.transform.localPosition=new Vector3(0,5,0);
		Cam2.transform.rotation=Quaternion.Euler(0,0,0);
	}

	/*
	 * Changes the view from the active camera to the incative camera
	 */
	public void ChangeCamera(){
		Cam1.enabled=!Cam1.enabled;
		Cam2.enabled=!Cam2.enabled;
	}

	/*
	 * Get-method for life
	 */
	public int GetLife(){
		return life;
	}
}
