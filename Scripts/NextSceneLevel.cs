using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneLevel : MonoBehaviour
{
    private int nextSceneToLoad;
    void Start()
    {
       nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1; 
    }

    
    public void NextLevel()
    {
        SceneManager.LoadScene(nextSceneToLoad);
        
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
