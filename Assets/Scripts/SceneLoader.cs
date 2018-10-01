using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    public float timeToMenu;
    public int menuScene;
    public int gameScene;

    private void Update()
    {

        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            timeToMenu -= Time.deltaTime;
        }

        if (SceneManager.GetActiveScene().buildIndex == 0 && timeToMenu < 0f)
        {
            SceneManager.LoadScene(menuScene);
        }
    }

    public void PlayGame ()
    {
        SceneManager.LoadScene(gameScene);
    }

    public void Menu()
    {
        SceneManager.LoadScene(menuScene);
    }

    public void QuitGame ()
    {
        Application.Quit();
    }
}
