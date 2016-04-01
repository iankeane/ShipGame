using UnityEngine;
using System.Collections;

public class StopToiletClog : MonoBehaviour {
	public EmergencyHandler EHandler;

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Gauntlet") {
			if (EHandler.currProblem == "toiletClog") {
				Debug.Log ("touched");
				GameObject.FindWithTag ("MainScreen").GetComponent<Animator>().SetBool ("toiletClog",false);
				GameObject.FindWithTag ("BathroomLight").GetComponent<Animator> ().SetBool ("redFlash", false);
				GameObject.FindWithTag ("BathroomLight").GetComponent<AudioSource> ().mute = true;
				GameObject.FindWithTag ("BathroomLightHall").GetComponent<Animator> ().SetBool ("redFlash", false);
				EHandler.resetEmergency ();
			}
		}
	}

}