using UnityEngine;
using System.Collections;

public class OjectRotation : MonoBehaviour {
    public float factor = 5;
    public float num;
    float counter;
	// Use this for initialization
	void Start () {
        counter = num;
	}
	
	// Update is called once per frame
	void Update () {
        if(counter>=num/2.0)
            transform.Rotate(Vector3.up *factor* Time.deltaTime);
        if(counter<num/2.0)
            transform.Rotate(Vector3.up * -factor * Time.deltaTime);
        counter -= Time.deltaTime;
        if (counter <= 0)
        {
            counter = num;
        }

	}
}
