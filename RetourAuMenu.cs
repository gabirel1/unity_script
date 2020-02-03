using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetourAuMenu : MonoBehaviour
{
    public void Return()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void Reload()
    {
        SceneManager.LoadScene("GameScene");
    }
}
