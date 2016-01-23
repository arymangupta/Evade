using UnityEngine;
using System.Collections;

public class Tut : MonoBehaviour {
    public Animation anim;
	// Use this for initialization
	void Start () {
        anim.Play();
        Destroy(gameObject, 4);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
