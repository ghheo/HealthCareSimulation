using UnityEngine;
using System.Collections;

public class RegistrationLine : MonoBehaviour {

	ArrayList registrationLine;

	void Start () {
		registrationLine = new ArrayList();
	}
	
	void Update () {
	
	}

	public void InsertPatientIntoRegistration(Patient pat){
		registrationLine.Add(pat);
	}
}
