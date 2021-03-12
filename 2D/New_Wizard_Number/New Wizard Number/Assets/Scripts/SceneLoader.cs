using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene(){
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex+1);
        }
    public void LoadStartScene()
    {
               /*int startScene;  
               int sceneNumber = SceneManager.sceneCount;
               for (var i = sceneNumber; i >= 0; i--)
               {
                   if (i == 0)
                   {
                       startScene = i;
                       SceneManager.LoadScene(startScene);
                   }
               }*/

        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
