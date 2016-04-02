using UnityEngine;
using System.Collections;

//This is the script that holds the information of the players inventory.

public class InventoryScript : MonoBehaviour {

	//Boolean variables for if the player has the object or not.
	public bool hasFireExtinguisher;
	public bool hasFirstAidKit;
	public bool hasCrutches;
	public bool hasRadio;
	public bool hasClock;
	public bool hasBatteries;
	public bool hasVitaminBottle;
	public bool hasFlashlight;
	public bool hasMedicalAlertTag;
	public bool hasSunscreen;

	// Use this for initialization
	//void Start () {
	//
	//}

	void Start()
	{
		//This will generate a random number between 1 and 4, we might be able to use this number based on item groups that will be set active
		int randomNumber;
		randomNumber = Random.Range (1, 5);
		Debug.Log ("Random Number Test: " + randomNumber);
	}

	//When these functions gets called, change the corresponding variable to true. - Debug.Logs are for testing
	public void getFireExtinguisher()
	{
		hasFireExtinguisher = true;
		Debug.Log ("You now have the Fire Extinguisher");
	}

	public void getFirstAidKit()
	{
		hasFirstAidKit = true;
		Debug.Log ("You now have the First Aid Kit");
	}

	public void getRadio()
	{
		hasRadio = true;
		Debug.Log ("You now have the Radio");
	}

	public void getClock()
	{
		hasClock = true;
		Debug.Log ("You now have the Clock");
	}

	public void getBatteries()
	{
		hasBatteries = true;
		Debug.Log ("You now have the Batteries");
	}

	public void getVitaminBottle()
	{
		hasVitaminBottle = true;
		Debug.Log ("You now have the Vitamin Bottle");
	}

	public void getFlashlight()
	{
		hasFlashlight = true;
		Debug.Log ("You now have the Flashlight");
	}

	public void getMedicalAlertTag()
	{
		hasMedicalAlertTag = true;
		Debug.Log ("You now have the Medical Alert Tag");
	}

	public void getSunscreen()
	{
		hasSunscreen = true;
		Debug.Log ("You now have the Sunscreen");
	}

	public void getCrutches()
	{
		hasCrutches = true;
		Debug.Log ("You now have the Crutches");
	}

	//This is an alternate way to display the information that might possible result in less lines of code needing to be written.
	//Alternately, in the item script, it is making hasCrutches true in this script, then calling the displayInformation() function.
	//public void displayInformation()
	//{
	//	if (hasCrutches) 
	//	{
	//		Debug.Log ("You now have the Crutches");
	//	}
	//}

	// Update is called once per frame
	//void Update () {
		//if (hasFireExtinguisher) {
		//	Debug.Log ("You now have the fire extinguisher");
		//}

		//if (hasFirstAidKit) {
		//	Debug.Log ("You now have the first aid kit");
		//}

	//}
}
