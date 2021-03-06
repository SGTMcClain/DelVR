using UnityEngine;
using System.Collections;

public class MoveMain : MonoBehaviour {

	//Assigned the CardboardMain object to the variable
	public Transform CardBoardMain;

	//public MoveMain moveMain;

	//Variables for all the Arrows in the scene
	//public GameObject SimpleArrow;
	//public GameObject SimpleArrow1;
	//public GameObject SimpleArrow2;
	//public GameObject SimpleArrow3;
	//public GameObject SimpleArrow4;
	//public GameObject SimpleArrow5;

	public GameManager gameManager;



	//void Start()
	//{
		//Find all the Arrows in the scene and attach them to the variables
		//SimpleArrow = GameObject.Find("Navigation/Simple Arrow");
		//SimpleArrow1 = GameObject.Find("Navigation/Simple Arrow (1)");
		//SimpleArrow2 = GameObject.Find("Navigation/Simple Arrow (2)");
		//SimpleArrow3 = GameObject.Find("Navigation/Simple Arrow (3)");
		//SimpleArrow4 = GameObject.Find("Navigation/Simple Arrow (4)");
		//SimpleArrow5 = GameObject.Find("Navigation/Simple Arrow (5)");
	//}


	//starting transform - 0, 1.5, 0

	void Awake()
	{
		gameManager = GameObject.Find ("GameManager").GetComponent<GameManager> ();
	}

	//For each function, move the position of main, and disable and enable the corresponding arrows
	void MoveMainUpstairs () {

		CardBoardMain.transform.localPosition = new Vector3 (1.662f, 3.85f, -2.9525f);
		gameManager.SimpleArrow.SetActive (false);
		gameManager.SimpleArrow3.SetActive (false);
		gameManager.SimpleArrow1.SetActive (true);
		gameManager.SimpleArrow2.SetActive (true);
		gameManager.SimpleArrow4.SetActive (false);
		gameManager.SimpleArrow8.SetActive (false);

	}

	void MoveMainDownstairs ()
	{
		CardBoardMain.transform.localPosition = new Vector3 (0, 1.5f, 0);
		gameManager.SimpleArrow.SetActive (true);
		gameManager.SimpleArrow4.SetActive (true);
		gameManager.SimpleArrow1.SetActive (false);
		gameManager.SimpleArrow2.SetActive (false);
		gameManager.SimpleArrow5.SetActive (false);
		gameManager.SimpleArrow6.SetActive (false);
	}

	void MoveMainUpstairsRoom()
	{
		CardBoardMain.transform.localPosition = new Vector3 (-5.282f, 3.85f, -1.379f);
		gameManager.SimpleArrow3.SetActive (true);
		gameManager.SimpleArrow1.SetActive (false);
		gameManager.SimpleArrow4.SetActive (false);
		gameManager.SimpleArrow8.SetActive (true);
		gameManager.SimpleArrow9.SetActive (false);
	}
		
	void MoveMainDownstairsRoom()
	{
		CardBoardMain.transform.localPosition = new Vector3 (-5.75f, 1.5f, -0.53f);
		gameManager.SimpleArrow5.SetActive (true);
		gameManager.SimpleArrow.SetActive (false);
		gameManager.SimpleArrow4.SetActive (false);
		gameManager.SimpleArrow6.SetActive (true);
		gameManager.SimpleArrow7.SetActive (false);
	}

	void MoveMainKitchenTable()
	{
		CardBoardMain.transform.localPosition = new Vector3 (-5.152f, 1.5f, 1.154f);
		gameManager.SimpleArrow5.SetActive (false);
		gameManager.SimpleArrow6.SetActive (false);
		gameManager.SimpleArrow7.SetActive (true);
	}

	void MoveMainUpstairsBed()
	{
		CardBoardMain.transform.localPosition = new Vector3 (-5.163f, 3.85f, 1.616f);
		gameManager.SimpleArrow3.SetActive (false);
		gameManager.SimpleArrow8.SetActive (false);
		gameManager.SimpleArrow9.SetActive (true);
	}
}

