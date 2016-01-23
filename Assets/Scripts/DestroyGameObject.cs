using UnityEngine;
using System.Collections;

public class DestroyGameObject : MonoBehaviour {
    public float lifetime;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(gameObject, lifetime);
    }
}
