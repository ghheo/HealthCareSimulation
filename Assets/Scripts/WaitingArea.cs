using UnityEngine;
using System.Collections;

public class WaitingArea : MonoBehaviour {

	ArrayList waitingArea;

	void Start () {
		waitingArea = new ArrayList();
	}
	
	void Update () {
	
	}
	public void InsertPatientIntoRegistration(Patient pat){
		waitingArea.Add (pat);
	}
}
