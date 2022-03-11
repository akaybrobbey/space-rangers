using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour{
    public void PlayGame ()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void backMenu ()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void openInstruct ()
    {
        SceneManager.LoadScene("Instructions", LoadSceneMode.Single);
    }
}
