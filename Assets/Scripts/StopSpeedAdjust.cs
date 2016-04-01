using UnityEngine;
using System.Collections;

public class StopSpeedAdjust : MonoBehaviour {
	public EmergencyHandler EHandler;

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Gauntlet") {
			if (EHandler.currProblem == "speedAdjust") {
				Debug.Log ("touched");
				GameObject.FindWithTag ("MainScreen").GetComponent<Animator>().SetBool ("speedAdjust",false);
				GameObject.FindWithTag ("FrontRoomLight1").GetComponent<Animator> ().SetBool ("redFlash", false);
				GameObject.FindWithTag ("FrontRoomLight1").GetComponent<AudioSource> ().mute = true;
				GameObject.FindWithTag ("FrontRoomLight2").GetComponent<Animator> ().SetBool ("redFlash", false);
				EHandler.resetEmergency ();
			}
		}
	}

}