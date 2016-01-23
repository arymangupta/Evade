using UnityEngine;
using System.Collections;

public class CreditsScript : MonoBehaviour {
    public float moveSpeed;
    public float maxDistance;
    Vector3 pos;
	// Use this for initialization
	void Start () {
        pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position = Vector3.MoveTowards(transform.position,pos+Vector3.up * maxDistance, moveSpeed*Time.deltaTime);
    }
}
