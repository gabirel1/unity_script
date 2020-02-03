using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour {

public GameObject ui;

	void Update()
	{
		if (Input.GetKeyDown(key: KeyCode.Escape)) // Si la touche (Echap) est appuyés, on apelle la fonction Toggle()
		{
			Toggle();
		} 
	}

	void Toggle() 
	{
		ui.SetActive(!ui.activeSelf);

		if (ui.activeSelf)
		{
			Time.timeScale = 0f; //On définie le temps sur 0 (on coupe l'écoulement du temps)
		}
		else
		{
			Time.timeScale = 1f; //On définie le temps sur 1 (on remet l'écoulement du temps)
		}
	}

	public void Return() 
	{
		SceneManager.LoadScene("MainMenuScene"); // On appelle la fonction SceneManager, et on lui demande de charger la scène MainMenuScene
	}

	public void Quit()
	{
		Application.Quit();
	}	
}
