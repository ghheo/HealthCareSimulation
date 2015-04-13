using UnityEngine;
using System.Collections;

public class WaitingArea : MonoBehaviour {

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
