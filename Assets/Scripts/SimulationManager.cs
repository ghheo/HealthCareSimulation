using UnityEngine;
using System.Collections;

//use this class to do main task
public class SimulationManager : MonoBehaviour {

	float timer = 0; // this is countdown timer | for time elapsed since startup use Time.realtimeSinceStartup

	WaitingArea waitingArea;
	Registration registration;

	RandomClass random;
	Patient patient;

	void Start(){
		random = gameObject.AddComponent<RandomClass>(); // if we dont add this to object then we get null pointer error.
		registration = gameObject.AddComponent<Registration>();
	}

	void Update () {
		timer += Time.deltaTime; // basic countdown which will get reset after limited time
		float rTime = RandomClass.getRandomTime(2.0f,4.0f,100); // this is random average time coming from randomClass

		if(timer >= 1){ 
			patient = new Patient(RandomPatientType(),Time.realtimeSinceStartup);
			registration.InsertPatientIntoRegistration(patient);
			print("patient in registration area: "+registration.PatientInLine());

			timer = 0; 
		}



		// search through patientRegistration and find which patient been waiting for 10 secs. and remove them(renege) 
		for (int index = registration.PatientInLine() - 1; index >= 0; index--)
		{
			Patient pat = (Patient)registration.registrationLine[index];
			if (pat.willRenege == true && pat.waitingFor >= 5.0f)
			{
				print(pat.patientType + " type patient reneging");
				registration.registrationLine.RemoveAt(index); 
			}
		}
	}

	//Generate random patient type based on 3 patient type reneging,normal,emergency(ambulance)
	public PatientType RandomPatientType(){
        //if(RandomClass.willRenege()){
        //    return PatientType.Reneging;
        //}
		return (PatientType)(UnityEngine.Random.Range(1, PatientType.GetNames(typeof(PatientType)).Length));
	}
}
