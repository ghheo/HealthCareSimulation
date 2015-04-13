using UnityEngine;
using System.Collections;

//use this class to do main task
public class SimulationManager : MonoBehaviour {

	float timer = 0; // this is countdown time  for time elapsed since startup use Time.realtimeSinceStartup

	WaitingArea waitingArea;
	RegistrationLine registration;

	RandomClass random;
	Patient patient;

	void Start(){
		gameObject.AddComponent<RandomClass>(); // if we dont add this to object then we get null pointer error.
		random = gameObject.GetComponent<RandomClass>();		
		registration = gameObject.AddComponent<RegistrationLine>();
	}

	void Update () {
		timer += Time.deltaTime; // basic countdown which will get reset after limited time
		float rTime = random.getRandomTime(2.0f,4.0f,100);

		if(timer >= 1){ // every N second create patient and add patient to waiting list
			patient = new Patient(RandomPatientType(),Time.realtimeSinceStartup);
			registration.InsertPatientIntoRegistration(patient);
			print("patient in registration area: "+registration.PatientInLine());
			timer = 0; 
		}

		// search through patientRegistration and find which patient been waiting for 10 secs. and remove them
		// but If condition not properly working here. patient does get remove after 10 secs thou.
		for (int index = registration.PatientInLine() - 1; index >= 0; index--)
		{
			Patient pat = (Patient)registration.registrationLine[index];
			if (pat.patientType.Contains(PatientType.Reneging.ToString()) && pat.waitingFor >= 5.0f)
			{
				print(pat.patientType + " type patient reneging");
				registration.registrationLine.RemoveAt(index); // remove patient at index where paiting is waiting for 10 secs
			}
		}
	}


	//Generate random patient type based on 3 patient type reneging,normal,emergency(ambulance)
	public PatientType RandomPatientType(){
		if(random.willRenege()){
			return PatientType.Reneging;
		}
		return (PatientType)(UnityEngine.Random.Range(1, PatientType.GetNames(typeof(PatientType)).Length));
	}
}
