using UnityEngine;
using System.Collections;

/*
 * Script for the death by cogs
 */
public class CogDeath : MonoBehaviour {

	public bool died=false;
	public GameObject twisted;
	private God god;
	private GameObject cam2;

	// Use this for initialization
	void Start () {
		god=GameObject.FindObjectOfType(typeof(God)) as God;
		cam2=GameObject.Find("3rd_Camera");
	}
	
	// Update is called once per frame
	void Update () {
		if(!died&& transform.position.z>-38 && transform.position.z<-28 && transform.position.y<18 && transform.position.y>10 && transform.position.x<16 && transform.position.x>10){
			cam2.transform.rotation=Quaternion.Euler(0,-90,0);
			cam2.transform.Translate(new Vector3(0,0,-5));
			god.Die();
			Instantiate(twisted, new Vector3(9.49f, 10.6f, -31.5f), Quaternion.Euler(-90,-90,0));
			died=true;
		}
	}	
}
