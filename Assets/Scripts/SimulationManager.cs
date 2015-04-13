using UnityEngine;
using System.Collections;

//use this class to do main task
public class SimulationManager : MonoBehaviour {

	float timer = 0; // this is countdown time  for time elapsed since startup use Time.realtimeSinceStartup

	ArrayList waitingPatients,registrationLine;
	Queue triagePatients,treatMentPatients;
	RandomClass random;
	Patient patient;

	void Start(){
		gameObject.AddComponent<RandomClass>(); // if we dont add this to object then we get null pointer error.
		random = gameObject.GetComponent<RandomClass>();		
		waitingPatients = new ArrayList();
	}

	void Update () {
		timer += Time.deltaTime; // basic countdown which will get reset after limited time
		float rTime = random.getRandomTime(2.0f,4.0f,100);

		if(timer >= rTime){ // every N second create patient and add patient to waiting list
			patient = new Patient(RandomPatientType(),Time.realtimeSinceStartup);
			waitingPatients.Add(patient);
			print(waitingPatients.Count);
			timer = 0; 
			print("Now patient counts "+waitingPatients.Count);
		}

		// search through patientWaitinglist and find which patient been waiting for 10 secs. and remove them
		// but If condition not properly working here. patient does get remove after 10 secs thou.

		for (int index = waitingPatients.Count - 1; index >= 0; index--)
		{
			Patient entry = (Patient)waitingPatients[index];
			if (entry.waitingFor >= 10.0f)
			{
				print(entry + "patient leaving");
				waitingPatients.RemoveAt(index); // remove patient at index where paiting is waiting for 10 secs
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
