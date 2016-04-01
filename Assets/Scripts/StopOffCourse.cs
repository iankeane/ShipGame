using UnityEngine;
using System.Collections;

public class StopOffCourse : MonoBehaviour {
	public EmergencyHandler EHandler;

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Gauntlet") {
			Debug.Log ("touchedcontrol");
			if (EHandler.currProblem == "offCourse") {
				Debug.Log ("touchedcontrolemerg");
				GameObject.FindWithTag ("MainScreen").GetComponent<Animator>().SetBool ("offCourse",false);
				GameObject.FindWithTag ("FrontRoomLight1").GetComponent<Animator> ().SetBool ("redFlash", false);
				GameObject.FindWithTag ("FrontRoomLight1").GetComponent<AudioSource> ().mute = true;
				GameObject.FindWithTag ("FrontRoomLight2").GetComponent<Animator> ().SetBool ("redFlash", false);
				EHandler.resetEmergency ();
			}
		}
	}

}