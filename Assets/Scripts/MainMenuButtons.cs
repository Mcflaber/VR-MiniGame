using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public void LoadCombat()
    {
        Debug.Log("Load");
        SceneManager.LoadScene("Combat");
    }

    public void LoadPlinko()
    {
        Debug.Log("Load");
        SceneManager.LoadScene("Plinko");
    }

    public void LoadSoccer()
    {
        Debug.Log("Load");
        SceneManager.LoadScene("Soccer");
    }

    public void LoadMainMenu()
    {
        Debug.Log("Load");
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadAlienInvaders()
    {
        Debug.Log("Load");
        SceneManager.LoadScene("AlienInvaders");
    }



}

