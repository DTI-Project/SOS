using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void RefugeeMap()
    {
        SceneManager.LoadScene("Refugee Map");
    }

    public void About()
    {
        SceneManager.LoadScene("About Menu");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void AfterMath()
    {
        SceneManager.LoadScene("AfterMath");
    }
    
    public void Exit()
    {
     // save any game data here
     #if UNITY_EDITOR
         // Application.Quit() does not work in the editor so
         // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
         UnityEditor.EditorApplication.isPlaying = false;
     #else
         Application.Quit();
     #endif
     
     }
  
}
