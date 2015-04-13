using UnityEngine;
using System.Collections;

public class RandomClass : MonoBehaviour {
	float val = 0.0f;
	bool test;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Get Random time after finding the average 100 times
	public float getRandomTime(float min, float max, int times)
	{
		float sum = 0.0f;
		float average = 0.0f;
		float val;

		for(int i = 0; i < times; i++)
		{
			val = Random.Range(min, max);
			sum = sum + val;
		}

		average = sum / times;

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
