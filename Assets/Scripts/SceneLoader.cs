using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    public float timeToMenu;
    

    private void Update()
    {
        timeToMenu -= Time.deltaTime;

        if (timeToMenu < 0f)
        {timeToMenu -= Time.deltaTime;
        
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
