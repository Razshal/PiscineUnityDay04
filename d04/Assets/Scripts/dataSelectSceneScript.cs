using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dataSelectSceneScript : MonoBehaviour {
    public Text unlockedLevels;
    public Text lifeLoss;
    public Text ringsFound;
    public Text bestScore;

	// Use this for initialization
	void Start () {
        if (!PlayerPrefs.HasKey("unlockedLevels"))
            PlayerPrefs.SetInt("unlockedLevels", 0);
        if (!PlayerPrefs.HasKey("lifeLoss"))
            PlayerPrefs.SetInt("lifeLoss", 0);
        if (!PlayerPrefs.HasKey("ringsFound"))
            PlayerPrefs.SetInt("ringsFound", 0);
        if (!PlayerPrefs.HasKey("bestScore"))
            PlayerPrefs.SetInt("bestScore", 0);

        unlockedLevels.text = "Unlocked levels : " + PlayerPrefs.GetInt("unlockedLevels");
        lifeLoss.text = "Lives losed : " + PlayerPrefs.GetInt("lifeLoss");
        ringsFound.text = "Rings found : " + PlayerPrefs.GetInt("ringsFound");
        bestScore.text = "Best score : " + PlayerPrefs.GetInt("bestScore");
	}
}
