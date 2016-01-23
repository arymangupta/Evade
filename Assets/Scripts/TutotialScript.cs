using UnityEngine;
using System.Collections;

public class TutotialScript : MonoBehaviour {
    public Animation anim;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerController.PlayAnim)
        {
            anim.Play();
            PlayerController.PlayAnim = false;
        }
	}

}
