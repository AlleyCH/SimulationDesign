using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadCutScene()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadNextLevel()
    {
        //This will load the next scene in the buildIndex, e.g if in scene 3, go to scene 4
        SceneManager.LoadScene(1);

    }

    public void LoadNextLevel2()
    {
        //This will load the next scene in the buildIndex, e.g if in scene 3, go to scene 4
        SceneManager.LoadScene(3);

    }

    public void LoadNextLevel3()
    {
        //This will load the next scene in the buildIndex, e.g if in scene 3, go to scene 4
        SceneManager.LoadScene(3);

    }


}
