using UnityEngine;
using System.Collections;

public class WaitingArea : MonoBehaviour {

	//after patientgets registered they come here. for waiting to go to triage area
	public ArrayList waitingArea;

	void Start () {
		waitingArea = new ArrayList();
	}
	
	void Update () {
	
	}
	public void InsertPatientIntoWaiting(Patient pat){
		waitingArea.Add (pat);
	}

	public int PatientInWaitingArea(){
		return waitingArea.Count;
	}
}
