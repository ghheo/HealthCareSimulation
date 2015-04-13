using UnityEngine;
using System.Collections;


public enum PatientType{
	Normal,
	Emergency
}

public class Patient {

	public string patientType;
	public float waitingFor;
    public float treatmeantTime;
    public float timeInTreatment;
    public bool willRenege; 

	public Patient(){}

	//create each patient with patient type and give them global timestamp which will tell how long each patient waiting.
	public Patient(PatientType patType, float waitingFor){
		this.patientType = patType.ToString();
		this.waitingFor = waitingFor;
        this.willRenege = RandomClass.willRenege();

        //If the patient type is normal then their treatment time will be 5 min to 15 min
        if (this.patientType == PatientType.Normal.ToString())
        {
            //set treatmentTime to random Time

        }
        //If the patient type is emergeny then their treatment time will be 20 min to 45 min
        if (this.patientType == PatientType.Emergency.ToString())
        {

        }
	}




}


