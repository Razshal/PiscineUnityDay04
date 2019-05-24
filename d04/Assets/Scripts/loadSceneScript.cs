using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadSceneScript : MonoBehaviour {
    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadSceneByScene(Scene scene)
    {
        SceneManager.LoadScene(scene.name);
    }

    public void ReloadActiveScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
