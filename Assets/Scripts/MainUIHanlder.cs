using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif


[DefaultExecutionOrder(1000)]
public class MainUIHanlder : MonoBehaviour
{

    public void NewNameWritten(Text playerName)
    {
        MainManager.Instance.playerName = playerName; 
    }

    private void Start()
    {
        
    }



    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        MainManager.Instance.SaveScoreAndName();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
