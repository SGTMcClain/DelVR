using UnityEngine;
using System.Collections;

//This is the script that holds the information of the players inventory.

public class InventoryScript : MonoBehaviour {

	//Boolean variables for if the player has the object or not.
	public bool hasFireExtinguisher = false;
	public bool hasFirstAidKit = false;
	public bool hasCrutches = false;
	public bool hasBatteriesGroup = false;
	public bool hasCanGroup = false;
	public bool hasVitaminBottle = false;
	public bool hasFlashlight = false;
	public bool hasMedicalAlertTag = false;
	public bool hasSunscreen = false;

	//Setting up GameObject references


	//GameObject FireExtinguisher = GameObject.Find ("fire_extinguisher");

	// Use this for initialization
	//void Start () {
	//
	//}


	//Setting up items in Scene
	public GameObject FireExtinguisher;
	public GameObject FirstAidKit;
	public GameObject BatteriesGroup;
	public GameObject VitaminBottle;
	public GameObject Crutches;
	public GameObject Flashlight;
	public GameObject CanGroup;
	public GameObject Sunscreen;
	public GameObject MedicalAltertTag;

	//From the itemScript, this function can get called. It changes the boolean variable to true then displays it in the console.


	public void GetCollectibleItems(){
		//FireExtinguisher Collectible
		if(!FireExtinguisher.activeInHierarchy){
			hasFireExtinguisher = true;
			Debug.Log ("You now have the Fire Extinguisher");
		}
		else{
			hasFireExtinguisher = false;
		}

		//FirstAidKit Collectible
		if(!FirstAidKit.activeInHierarchy){
			hasFirstAidKit = true;
			Debug.Log ("You now have the FirstAidKit");
		}
		else{
			hasFirstAidKit = false;
		}

		//BatteriesGroup Collectible
		if(!BatteriesGroup.activeInHierarchy){
			hasBatteriesGroup = true;
			Debug.Log ("You now have the Batteries");
		}
		else{
			hasBatteriesGroup = false;
		}

		//VitaminBottle Collectible
		if(!VitaminBottle.activeInHierarchy){
			hasVitaminBottle = true;
			Debug.Log ("You now have the Vitamin Bottle");
		}
		else{
			hasVitaminBottle = false;
		}

		//Crutches Collectible
		if(!Crutches.activeInHierarchy){
			hasCrutches = true;
			Debug.Log ("You now have the Crutches");
		}
		else{
			hasCrutches = false;
		}

		//Flashlight Collectible
		if(!Flashlight.activeInHierarchy){
			hasFlashlight = true;
			Debug.Log ("You now have the Crutches");
		}
		else{
			hasFlashlight = false;
		}

		//CanGroup Collectible
		if(!CanGroup.activeInHierarchy){
			hasCanGroup = true;
			Debug.Log ("You now have the CanGroup");
		}
		else{
			hasCanGroup = false;
		}

		//Flashlight Collectible
		if(!Sunscreen.activeInHierarchy){
			hasSunscreen = true;
			Debug.Log ("You now have the Sunscreen");
		}
		else{
			hasSunscreen = false;
		}

		//MedicalAlertTag Collectible
		if(!MedicalAltertTag.activeInHierarchy){
			hasMedicalAlertTag = true;
			Debug.Log ("You now have the MedicalAlertTag");
		}
		else{
			hasMedicalAlertTag = false;
		}
	}

	/*
	public void getFireExtinguisher()
	{
		if (!FireExtinguisher.activeInHierarchy) {
			hasFireExtinguisher = true;
			Debug.Log ("You now have the Fire Extinguisher");
		}
		else{
			hasFireExtinguisher = false;
		}
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
	*/

	//This is an alternate way to display the information that might possible result in less lines of code needing to be written.
	//Alternately, in the item script, it is making hasCrutches true in this script, then calling the displayInformation() function.
	public void displayInformation()
	{
		if (hasCrutches) 
		{
			Debug.Log ("You now have the Crutches");
		}
	}

	// Update is called once per frame
	void Update () {

		GetCollectibleItems ();

		/*
		if (hasFireExtinguisher) {
			Debug.Log ("You now have the fire extinguisher");
		}

		if (hasFirstAidKit) {
			Debug.Log ("You now have the first aid kit");
		}
		*/

	}
}
