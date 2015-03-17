using UnityEngine;
using System.Collections;

public enum PatientType{
	Reneging,
	Normal,
	Emergency
}

public class Patient {

	public string patientType;



	public Patient(PatientType patType){
		this.patientType = patType.ToString();
	}



}


