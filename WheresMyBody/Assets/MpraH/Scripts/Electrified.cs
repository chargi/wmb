using UnityEngine;
using System.Collections;

/*
 * Unused script that plays the Shock-Animation for an electrified palyer model
 */
public class Electrified : MonoBehaviour {
	private Animator animator;
	// Use this for initialization
	void Start () {
		animator=GetComponent<Animator>();
		animator.Play("Shock");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
