using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public Button Play_Button;
	public Button Quit_Button;
	public Button Home_Button;


	public void Play_Game () {
		Debug.Log ("Play Game");
		SceneManager.LoadScene (0);
	}
	public void Quit_Game() {

		Application.Quit (); 
	} 
	public void Home () {
		Debug.Log ("In Main");
		SceneManager.LoadScene (1);
	} 
}