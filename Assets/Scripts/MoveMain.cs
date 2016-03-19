using UnityEngine;
using System.Collections;

public class MoveMain : MonoBehaviour {

	//Assigned the CardboardMain object to the variable
	public Transform CardBoardMain;

	//Variables for all the Arrows in the scene
	public GameObject SimpleArrow;
	public GameObject SimpleArrow1;
	public GameObject SimpleArrow2;
	public GameObject SimpleArrow3;
	public GameObject SimpleArrow4;
	public GameObject SimpleArrow5;

	//IEnumerator to call a function after "x" amount of seconds
	delegate void DelayedMethod();

	IEnumerator WaitAndDo(float time, DelayedMethod method)
	{
		yield return new WaitForSeconds(time);
		method();
	}


	void Start()
	{
		//Find all the Arrows in the scene and attach them to the variables
		SimpleArrow = GameObject.Find("Navigation/Simple Arrow");
		SimpleArrow1 = GameObject.Find("Navigation/Simple Arrow (1)");
		SimpleArrow2 = GameObject.Find("Navigation/Simple Arrow (2)");
		SimpleArrow3 = GameObject.Find("Navigation/Simple Arrow (3)");
		SimpleArrow4 = GameObject.Find("Navigation/Simple Arrow (4)");
		SimpleArrow5 = GameObject.Find("Navigation/Simple Arrow (5)");

		//After half a second, Hide all the arrows that you don't want the player to see
		StartCoroutine(WaitAndDo(.5f, hideArrows));
	}

	void hideArrows()
	{
		//Disabling all the arrows
		SimpleArrow1.SetActive (false);
		SimpleArrow2.SetActive (false);
		SimpleArrow3.SetActive (false);
		SimpleArrow5.SetActive (false);
	}

	//starting transform - 0, 1.5, 0

	//For each function, move the position of main, and disable and enable the corresponding arrows
	void MoveMainUpstairs () {

		CardBoardMain.transform.localPosition = new Vector3 (1.662f, 3.85f, -2.9525f);
		SimpleArrow.SetActive (false);
		SimpleArrow4.SetActive (false);
		SimpleArrow1.SetActive (true);
		SimpleArrow2.SetActive (true);
		SimpleArrow3.SetActive (false);

	}

	void MoveMainDownstairs ()
	{
		CardBoardMain.transform.localPosition = new Vector3 (0, 1.5f, 0);
		SimpleArrow.SetActive (true);
		SimpleArrow4.SetActive (true);
		SimpleArrow1.SetActive (false);
		SimpleArrow2.SetActive (false);
		SimpleArrow5.SetActive (false);
	}

	void MoveMainUpstairsRoom()
	{
		CardBoardMain.transform.localPosition = new Vector3 (-5.282f, 3.85f, -1.379f);
		SimpleArrow3.SetActive (true);
		SimpleArrow1.SetActive (false);
		SimpleArrow4.SetActive (false);
	}
		
	void MoveMainDownstairsRoom()
	{
		CardBoardMain.transform.localPosition = new Vector3 (-5.75f, 1.5f, -0.53f);
		SimpleArrow5.SetActive (true);
		SimpleArrow.SetActive (false);
		SimpleArrow4.SetActive (false);
	}
}

