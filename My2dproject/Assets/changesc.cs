using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changesc : MonoBehaviour {

    public void scenechange()
    {
        
        SceneManager.LoadScene("Finding");
    }

    public void scenechange2()
    {
        SceneManager.LoadScene("secondlevel");
        Time.timeScale = 1;
    }

    public void secondlevelcng()
    {
        SceneManager.LoadScene("level2");
        Time.timeScale = 1;
    }

    public void mainmenucng()
    {
        SceneManager.LoadScene("menu");
        Time.timeScale = 1;
    }

    public void mainscene()
    {
        SceneManager.LoadScene("Finding");
        Time.timeScale = 1;
    }

    public void mecng()
    {
        SceneManager.LoadScene("me");
        Time.timeScale = 1;
    }
}
