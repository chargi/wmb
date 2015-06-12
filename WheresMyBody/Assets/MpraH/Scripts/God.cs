using UnityEngine;
using System.Collections;

public class God : MonoBehaviour {
	private int life=0;
	private bool dying=false;
	private float turnSpeed=1f;
	public Camera Cam1;
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

	public void Die(){
		ChangeCamera();
		dying=true;
	}

	public void Respawn(){
		life++;
		FPSController.transform.position=new Vector3(0-4*life,1,-103);
		Destroy(GameObject.Find("Player_inactive_"+life));
		ChangeCamera();
		Cam2.transform.localPosition=new Vector3(0,5,0);
		Cam2.transform.rotation=Quaternion.Euler(0,0,0);
	}

	public void ChangeCamera(){
		Cam1.enabled=!Cam1.enabled;
		Cam2.enabled=!Cam2.enabled;
	}

	public int GetLife(){
		return life;
	}
}
