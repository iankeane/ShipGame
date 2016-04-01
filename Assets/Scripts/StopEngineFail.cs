using UnityEngine;
using System.Collections;

public class StopEngineFail : MonoBehaviour {
	public EmergencyHandler EHandler;

	void OnCollisionEnter(Collision col){
//		GameObject.FindWithTag ("EngineSwitch").GetComponent<Animation> ().Play ("SwitchFlip");
		if (col.gameObject.tag == "Gauntlet") {
			if (EHandler.currProblem == "engineFail") {
				Debug.Log ("touched");
				GameObject.FindWithTag ("MainScreen").GetComponent<Animator>().SetBool ("engineFail",false);
				GameObject.FindWithTag ("EngineRoomLight1").GetComponent<Animator> ().SetBool ("redFlash", false);
				GameObject.FindWithTag ("EngineRoomLight2").GetComponent<AudioSource> ().mute = true;
				GameObject.FindWithTag ("EngineRoomLight2").GetComponent<Animator> ().SetBool ("redFlash", false);
				EHandler.resetEmergency ();
			}
		}
	}

}