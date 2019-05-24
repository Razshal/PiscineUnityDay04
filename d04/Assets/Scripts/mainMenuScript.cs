using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuScript : MonoBehaviour {
    void Update () 
    {
            if (Input.GetKeyDown(KeyCode.Return))
                SceneManager.LoadScene("DataSelect");
    }

    public void resetPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
}
