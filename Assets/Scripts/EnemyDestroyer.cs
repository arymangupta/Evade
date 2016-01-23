using UnityEngine;
using System.Collections;

public class EnemyDestroyer : MonoBehaviour {
    public float yPos;
    // Use this for initialization
    void Start () {
       
        //print(PlayerController.currentScore);
    }
    void Update()
    {
        if (gameObject.transform.position.y <= yPos)
            Destroy(gameObject);
    }
}
