using UnityEngine;
using System.Collections;

public class RegistrationLine : MonoBehaviour {

	public ArrayList registrationLine;

	void Start () {
		registrationLine = new ArrayList();
	}
	
	void Update () {
	
	}

	public void InsertPatientIntoRegistration(Patient pat){
		registrationLine.Add(pat);
	}
	public int PatientInLine(){
		return registrationLine.Count;
	}
}
