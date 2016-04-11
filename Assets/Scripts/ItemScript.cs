using UnityEngine;
using System.Collections;

public class ItemScript : MonoBehaviour {

	//This is a script I made to pass along boolean variables to the inventory script attached to the gameManager. This will be placed on all the interactable gameObjects we plan for the player to find in our world.

	//variable to hold the inventoryScript
	public InventoryScript inventoryScript;

	//When the scene loads, this will find the GameManager gameobject then find the InventoryScript inside it and attach it to the inventoryScript varaible.
	void Awake()
	{
		/*

		inventoryScript = GameObject.Find ("GameManager").GetComponent<InventoryScript> ();
	}
		
	void getFirstAidKit ()
	{
		inventoryScript.getFirstAidKit();
	}

	void getFireExtinguisher()
	{
		inventoryScript.getFireExtinguisher();
	}

	void getRadio()
	{
		inventoryScript.getRadio();
	}

	void getClock()
	{
		inventoryScript.getClock();
	}

	void getBatteries()
	{
		inventoryScript.getBatteries();
	}

	void getVitaminBottle()
	{
		inventoryScript.getVitaminBottle();
	}

	void getFlashlight()
	{
		inventoryScript.getFlashlight();
	}

	void getMedicalAlertTag()
	{
		inventoryScript.getMedicalAlertTag();
	}

	void getSunscreen()
	{
		inventoryScript.getSunscreen();
	}
	*/
	}




	//Alternate way we can write this script, this involves setting the variable to true directly in this script, then calling a displayInformation function to show it in the inventory
	void getCrutches()
	{
		inventoryScript.hasCrutches = true;
		inventoryScript.displayInformation();
	}


	// Update is called once per frame
	//void Update () {
	//
	//}
}
