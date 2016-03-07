using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UI_Buttons : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Exit(){
	
		Application.Quit ();
	
	}

	public void Restart(){
		//Application.LoadLevel (0);  //Application LoadLevel has been depricated 
		//to use SceneManager.LoadScene you must place using UnityEngine.SceneManagment at the top
		SceneManager.LoadScene (0);
	}

	public void Credits(){
		//Button function for Credits
	}

	public void Reviews(){
		//Button function for Reviews
	}

	public void LevelSelect(){
		//Button function for Level Select Scene
		SceneManager.LoadScene(1);

	}

	public void MainMenu(){
		SceneManager.LoadScene (0);
	}

	public void Feedback(){
		Application.OpenURL ("http://goo.gl/forms/szdeyLl4lz");
	}

	//public static void LoadScene(int sceneBuildIndex, SceneManagement.LoadSceneMode mode = LoadSceneMode.Single);
}
