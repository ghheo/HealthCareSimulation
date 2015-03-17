using UnityEngine;
using System.Collections;

public class SimulationManager : MonoBehaviour {

	ArrayList waitingPatients;
	Queue triagePatients,treatMentPatients;


	void Start () {
		waitingPatients = new ArrayList();
		Patient pat1 = new Patient(PatientType.Emergency);
		waitingPatients.Add(pat1);

		print (waitingPatients.Count);
	}
	
	void Update () {
		
	}
}
