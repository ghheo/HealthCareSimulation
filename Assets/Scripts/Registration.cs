using UnityEngine;
using System.Collections;

public class Registration: MonoBehaviour {

	//this system is for registration line which holds patient after they generate. they come here based on real life scenario
	float timer = 0;

	public bool serve = false;

	public ArrayList registrationLine;
	WaitingArea waiting;

	void Start () {
		registrationLine = new ArrayList();
		waiting = GetComponent<WaitingArea>();

	}

	// some problem here
	void Update () {
		timer += Time.deltaTime;

		if(timer >= 3){
			serve = true;
			print(serve);
			timer = 0;
		}
		if(!serve){
			print (serve);
		}

	}
	// this block 

	public bool Serving(){
		return serve;
	}

	public void InsertPatientIntoRegistration(Patient pat){
		registrationLine.Add(pat);
	}
	public int PatientInLine(){
		return registrationLine.Count;
	}
	public Patient MovingToWaiting(Patient pat){

		registrationLine.Remove(pat);
		waiting.SendMessage("InsertPatientIntoWaiting",pat);

		return pat;
	}
}
