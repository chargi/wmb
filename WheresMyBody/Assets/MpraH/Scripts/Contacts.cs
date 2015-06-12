using UnityEngine;
using System.Collections;

public class Contacts : MonoBehaviour {
	private bool activated=false;
	private God god;
	private Forgedoor forgedoor;
	public GameObject pl_el;

	// Use this for initialization
	void Start () {
		god=GameObject.FindObjectOfType(typeof(God)) as God;
		forgedoor=GameObject.FindObjectOfType(typeof(Forgedoor)) as Forgedoor;
	}
	
	// Update is called once per frame
	void Update () {
		if(!activated && Input.GetKeyDown(KeyCode.E)){
			activated=true;
			Instantiate(pl_el, new Vector3(85, 0, -90), Quaternion.Euler(0,0,0));
			god.Die();
			forgedoor.OpenDoor();
			print("true");
		}
	}
	
}
