using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

  public void Play() 
  {
    SceneManager.LoadScene("GameScene");
  }

  public void Play2()
  {
        SceneManager.LoadScene("RulesCredits");
  }

  public void Quit()
  {
    Application.Quit();
  }
}
