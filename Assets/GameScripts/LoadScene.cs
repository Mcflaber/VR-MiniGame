using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadGame()
    {
        SceneManager.LoadScene("BasicScene");
    }
    public void LoadnextLevel()
    {
        SceneManager.LoadScene("BasicScene 1");
    }
    public void Quit()
    {
        Debug.Log("Quit Applicaiton");
    }
    public void Escape()
    {
        SceneManager.LoadScene("Start");
    }
}