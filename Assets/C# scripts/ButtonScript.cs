using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{

    public void backMenu ()
    {
        SceneManager.LoadScene("Menu");
    }

    public void openInstruct ()
    {
        SceneManager.LoadScene("InstrucionsCanvas");
    }
    
}
