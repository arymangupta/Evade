using UnityEngine;
using System.Collections;
using System.Collections.Generic;
[RequireComponent(typeof(AudioSource))]
public class ButtonClicks : MonoBehaviour {
    public AudioClip clipClick;
    public GameObject LoadingScreen;
	// Use this for initialization
    void Update()
    {
        if (Input.GetButtonDown("Cancel") == true)
        {
            AudioSource.PlayClipAtPoint(clipClick, new Vector3(0, 0, 0));
                Application.LoadLevel(0);

        }
    }
	public void play()
    {
        if (GoogleMobileAdsDemoScript.isAdPresent)
        {
            GoogleMobileAdsDemoScript.destrotAdd();
            GoogleMobileAdsDemoScript.isAdPresent = false;
        }
        AudioSource.PlayClipAtPoint(clipClick, new Vector3(0, 0, 0));
        Destroy(GameObject.Find("ScoreSystem")); // for correct scoring otherwise missing object expection
        Instantiate(LoadingScreen);
        Application.LoadLevel(1);
    }
    public void playAgain()
    {
        if (GoogleMobileAdsDemoScript.isAdPresent)
        {
            GoogleMobileAdsDemoScript.destrotAdd();
            GoogleMobileAdsDemoScript.isAdPresent = false;
        }
        AudioSource.PlayClipAtPoint(clipClick, new Vector3(0, 0, 0));
        Instantiate(LoadingScreen);
        Application.LoadLevel(1);
        
    }
   
    public void quit()
    {
        AudioSource.PlayClipAtPoint(clipClick, new Vector3(0, 0, 0));
        Application.Quit();
    }
    public void MainMenu()
    {
        AudioSource.PlayClipAtPoint(clipClick, new Vector3(0, 0, 0));
        Application.LoadLevel(0);
    }
    public void highScore()
    {
        AudioSource.PlayClipAtPoint(clipClick, new Vector3(0, 0, 0));
        Application.LoadLevel(3);
    }
    public void About()
    {
        AudioSource.PlayClipAtPoint(clipClick, new Vector3(0, 0, 0));
        Application.LoadLevel(4);
    }

}
