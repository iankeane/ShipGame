using UnityEngine;
using System.Collections;

public class EmergencyHandler : MonoBehaviour {

	public bool emergency = false;

	public string[] emergencyType = { "engineFail", "speedAdjust", "offCourse", "toiletClog" };

	public string currProblem = "";

	void Start () {
		StartCoroutine (createProblems());
	}

	IEnumerator createProblems(){
		while(true){
			Debug.Log ("started");
			int waitTime = Random.Range (0, 15);
			yield return new WaitForSeconds (waitTime);
			if (!emergency) {
				emergency = true;
				currProblem = emergencyType[Random.Range(0,emergencyType.Length)];
				if (currProblem == "engineFail") {
					GameObject.FindWithTag ("MainScreen").GetComponent<Animator>().SetBool ("engineFail",true);
					GameObject.FindWithTag ("EngineRoomLight1").GetComponent<Animator> ().SetBool ("redFlash", true);
					GameObject.FindWithTag ("EngineRoomLight2").GetComponent<AudioSource> ().Play();
					GameObject.FindWithTag ("EngineRoomLight2").GetComponent<AudioSource> ().mute = false;
					GameObject.FindWithTag ("EngineRoomLight2").GetComponent<Animator> ().SetBool ("redFlash", true);
				}
				if (currProblem == "speedAdjust") {
					GameObject.FindWithTag ("MainScreen").GetComponent<Animator>().SetBool ("speedAdjust",true);
					GameObject.FindWithTag ("FrontRoomLight1").GetComponent<Animator> ().SetBool ("redFlash", true);
					GameObject.FindWithTag ("FrontRoomLight1").GetComponent<AudioSource> ().Play();
					GameObject.FindWithTag ("FrontRoomLight1").GetComponent<AudioSource> ().mute = false;
					GameObject.FindWithTag ("FrontRoomLight2").GetComponent<Animator> ().SetBool ("redFlash", true);
				}
				if (currProblem == "offCourse") {
					GameObject.FindWithTag ("MainScreen").GetComponent<Animator>().SetBool ("offCourse",true);
					GameObject.FindWithTag ("FrontRoomLight1").GetComponent<Animator> ().SetBool ("redFlash", true);
					GameObject.FindWithTag ("FrontRoomLight1").GetComponent<AudioSource> ().Play();
					GameObject.FindWithTag ("FrontRoomLight1").GetComponent<AudioSource> ().mute = false;
					GameObject.FindWithTag ("FrontRoomLight2").GetComponent<Animator> ().SetBool ("redFlash", true);
				}
				if (currProblem == "toiletClog") {
					GameObject.FindWithTag ("MainScreen").GetComponent<Animator>().SetBool ("toiletClog",true);
					GameObject.FindWithTag ("BathroomLightHall").GetComponent<Animator> ().SetBool ("redFlash", true);
					GameObject.FindWithTag ("BathroomLight").GetComponent<Animator> ().SetBool ("redFlash", true);
					GameObject.FindWithTag ("BathroomLight").GetComponent<AudioSource> ().Play();
					GameObject.FindWithTag ("BathroomLight").GetComponent<AudioSource> ().mute = false;
				}
				Debug.Log (currProblem);
			}
		}
	}

	public void resetEmergency(){
		emergency = false;
	}

}
