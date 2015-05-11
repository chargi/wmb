#pragma strict

var count_E : int=0;
var Distance : float;
var MaxDistance : float=3.0;

function Update () {
	/*
	 * Aktion wenn E gedrueckt wird
	 */
	if(Input.GetButtonDown("Action")){
		var hit:RaycastHit;
		if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), hit)){
			Distance=hit.distance;
			if(Distance<MaxDistance){
				hit.transform.SendMessage("Use", count_E, SendMessageOptions.DontRequireReceiver);
				count_E++;
				print(count_E);
			}
		}
	}
	/*if(Input.GetKeyDown(KeyCode.E)){
		count_E++;
		print(count_E);
	}*/
}