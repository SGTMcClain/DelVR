using UnityEngine;
using System.Collections;



public class GameManager : MonoBehaviour {

	//IEnumerator to call a function after "x" amount of seconds
	//delegate void DelayedMethod();
	//
	//IEnumerator WaitAndDo(float time, DelayedMethod method)
	//{
	//	yield return new WaitForSeconds(time);
	//	method();
	//}

	//Variables for all the Arrows in the scene
	public GameObject SimpleArrow;
	public GameObject SimpleArrow1;
	public GameObject SimpleArrow2;
	public GameObject SimpleArrow3;
	public GameObject SimpleArrow4;
	public GameObject SimpleArrow5;
	public GameObject SimpleArrow6;
	public GameObject SimpleArrow7;
	public GameObject SimpleArrow8;
	public GameObject SimpleArrow9;

	// Use this for initialization
	//void Start () {



		//After half a second, Hide all the arrows that you don't want the player to see
		//StartCoroutine(WaitAndDo(.5f, hideArrows));
	
	//}

	void Awake()
	{
		//Finds all the Arrows in the scene and attaches them to the variables
		SimpleArrow = GameObject.Find("Navigation/Simple Arrow");
		SimpleArrow1 = GameObject.Find("Navigation/Simple Arrow (1)");
		SimpleArrow2 = GameObject.Find("Navigation/Simple Arrow (2)");
		SimpleArrow3 = GameObject.Find("Navigation/Simple Arrow (3)");
		SimpleArrow4 = GameObject.Find("Navigation/Simple Arrow (4)");
		SimpleArrow5 = GameObject.Find("Navigation/Simple Arrow (5)");
		SimpleArrow6 = GameObject.Find("Navigation/Simple Arrow (6)");
		SimpleArrow7 = GameObject.Find("Navigation/Simple Arrow (7)");
		SimpleArrow8 = GameObject.Find("Navigation/Simple Arrow (8)");
		SimpleArrow9 = GameObject.Find("Navigation/Simple Arrow (9)");

		//Disabling all the arrows we don't want the player to originally see.
		SimpleArrow1.SetActive (false);
		SimpleArrow2.SetActive (false);
		SimpleArrow3.SetActive (false);
		SimpleArrow5.SetActive (false);
		SimpleArrow6.SetActive (false);
		SimpleArrow7.SetActive (false);
		SimpleArrow8.SetActive (false);
		SimpleArrow9.SetActive (false);
	}
}
