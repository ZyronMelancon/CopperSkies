using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{

    public Canvas PauseCanvas;
    public Canvas OptionsCanvas;
    
	
	// Update is called once per frame
	public void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            PauseMenu();
        
    }

    public void PausetoOptions()
    {
        PauseCanvas.enabled = false;
        OptionsCanvas.enabled = true;
    }

    public void OptiontoPause()
    {
        OptionsCanvas.enabled = false;
        PauseCanvas.enabled = true;
    }

    public void BacktoMain()
    {
        PauseCanvas.enabled = false;
        SceneManager.LoadScene("01.Menu");
    }

    public void Resume()
    {
        PauseCanvas.enabled = false;
    }

    public void PauseMenu()
    {
        PauseCanvas.enabled = true;
        Debug.Log("I'm working");
    }
}
