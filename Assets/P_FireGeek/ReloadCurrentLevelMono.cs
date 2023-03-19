using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadCurrentLevelMono : MonoBehaviour
{

    public void ReloadCurrentScene(float delayInSeconds)
    {
        Invoke("ReloadCurrentScene", delayInSeconds);
    }

        public void ReloadCurrentScene()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ReloadTargetScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


}
