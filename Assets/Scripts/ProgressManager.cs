using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProgressManager : MonoBehaviour {

    public int currentLevel;
    // Use this for initialization
    void Start() {

        currentLevel = PlayerPrefs.GetInt("LvlStart");

    }

    // Update is called once per frame
    void Update() {

    }

    public void Resetprogress()
    {
        PlayerPrefs.SetInt("LvlStart", 0);
        currentLevel = PlayerPrefs.GetInt("LvlStart");
    }
    public void GameStart()
    {
        if (currentLevel == 0)
        {
            SceneManager.LoadScene("LoadingScene");
        }
        else if (currentLevel == 1)
        {
            SceneManager.LoadScene("LoadingScene2");
        }
    }

}
