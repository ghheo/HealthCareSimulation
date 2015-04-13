using UnityEngine;
using System.Collections;


public enum PatientType{
	Reneging,
	Normal,
	Emergency
}

public class Patient {

	public string patientType;
	public float waitingFor;

	public Patient(){}

	//create each patient with patient type and give them global timestamp which will tell how long each patient waiting.
	public Patient(PatientType patType, float waitingFor){
		this.patientType = patType.ToString();
		this.waitingFor = waitingFor;
	}




}


