using UnityEngine;
using System.Collections;

public class test1 : MonoBehaviour {

	void Start () {
		Patient pat = new Patient(PatientType.Emergency);
		print(pat.patientType);
	}
	
	void Update () {
		
	}
}
