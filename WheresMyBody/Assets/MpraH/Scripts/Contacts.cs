using UnityEngine;
using System.Collections;

/*
 * Script that creates the electrified player model when the contacts are touched
 */
public class Contacts : MonoBehaviour {
	private bool activated=false;
	private God god;
	private Forgedoor forgedoor;
	public GameObject pl_el;
	public GameObject player;

	// Use this for initialization
	void Start () {
		god=GameObject.FindObjectOfType(typeof(God)) as God;
		forgedoor=GameObject.FindObjectOfType(typeof(Forgedoor)) as Forgedoor;
	}
	
	// Update is called once per frame
	void Update () {
		if(!activated && Input.GetKeyDown(KeyCode.E)&& Vector3.Distance(this.transform.position, player.transform.position)<10){
			activated=true;
		    //GameObject el=Instantiate(pl_el, new Vector3(81.9f, 0, -89.6f), Quaternion.Euler(0,0,0)) as GameObject;
			//Animator an=el.GetComponent<Animator>();
			//an.Play("Shock");
			pl_el.transform.position=new Vector3(81.9f, 0, -89.6f);
			god.Die();
			forgedoor.OpenDoor();
			//print("true");
		}
	}
	
}
