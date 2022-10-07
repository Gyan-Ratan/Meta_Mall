using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   public void LoadNextScene(){
    int currentSceneIndex =SceneManager.GetActiveScene().buildIndex;
    SceneManager.LoadScene(currentSceneIndex +1);
   }

   public void LoadStartScene(){
      SceneManager.LoadScene(0);
   }
   public void MainMenu()
    {
        SceneManager.LoadScene(sceneName: "Main Menu");
    }
    public void OprnWVR()
    {
        SceneManager.LoadScene(sceneName: "Open VR");
    }
    public void OprnWNVR()
    {
        SceneManager.LoadScene(sceneName: "Open NVR");
    }
}
