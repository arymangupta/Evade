using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class EscapeScript : MonoBehaviour {
    int counter=0;
    public AudioClip clipClick;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetButtonDown("Cancel") == true)
        {
            if (GoogleMobileAdsDemoScript.isAdPresent)
            {
                GoogleMobileAdsDemoScript.destrotAdd();
                GoogleMobileAdsDemoScript.isAdPresent = false;
            }
            Destroy(GameObject.Find("ScoreSystem")); // for correct scoring otherwise missing object expection
            AudioSource.PlayClipAtPoint(clipClick, new Vector3(0, 0, 0));
            counter++;
            if (counter >= 2){
                counter = 0;
                Application.Quit();

            }
            if (counter == 1) 
            Application.LoadLevel(0);
           
        }
	}
}
