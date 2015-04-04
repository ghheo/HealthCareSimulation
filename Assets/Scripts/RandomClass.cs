using UnityEngine;
using System.Collections;

public class RandomClass : MonoBehaviour {
	float val = 0.0f;
	bool test;

	// Use this for initialization
	void Start () {
		val = getRandomTime(10.0f, 25.0f);
		Debug.Log(val);
		test = willRenege();
		Debug.Log (test);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Get Random time after finding the average 1000 times
	public float getRandomTime(float min, float max)
	{
		float sum = 0.0f;
		float average = 0.0f;
		float val;

		for(int i = 0; i < 100; i++)
		{
			val = Random.Range(min, max);
			sum = sum + val;
		}

		average = sum / 100;

		return average;
	}

	//
	public bool willRenege(){
		bool renege = false;

		float percentChance = Random.Range(0.0f, 100.0f);

		if(percentChance <= 9.5f)
		{
			renege = true;
		}

		return renege;
	}
}
