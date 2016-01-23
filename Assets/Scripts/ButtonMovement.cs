using UnityEngine;
using System.Collections;

public class ButtonMovement : TouchManager {

    public enum type { left , right , jump , play , highScore , about , quit};
    public type buttonType;
    public GameObject player = null;
    public GUITexture buttonTexure = null;
    public float MaxMovement=2.3f;
    public float maxSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        InputTouch(buttonTexure);
	}

    void OnFirstTouchEnded()
    {
        switch (buttonType)
        {
            case type.play:
                Application.LoadLevel(1);
                break;
            case type.highScore:

                break;

            case type.about:

                break;

            case type.quit:
                Application.Quit();
                break;
        }
    }
    void OnSecondTouchEnded()
    {
        switch (buttonType)
        {
            case type.jump:
               // player.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
                break;

        }
    }

    void OnFirstTouch() {
        switch (buttonType)
        {
            

            case type.left:
                if(player.transform.position.x >= -MaxMovement)
                player.transform.Translate(-Vector2.right * maxSpeed * Time.deltaTime);
                break;

            case type.right:
                if (player.transform.position.x <= MaxMovement)
                    player.transform.Translate(Vector2.right * maxSpeed * Time.deltaTime);
                break;
        }
    }
    void OnSecondTouch()
    {
        switch (buttonType)
        {


            case type.left:
                if (player.transform.position.x >= -MaxMovement)
                    player.transform.Translate(-Vector2.right * maxSpeed * Time.deltaTime);
                break;

            case type.right:
                if (player.transform.position.x <= MaxMovement)
                    player.transform.Translate(Vector2.right * maxSpeed * Time.deltaTime);
                break;
        }
    }
    void OnThirdTouch()
    {
        switch (buttonType)
        {


            case type.left:
                if (player.transform.position.x >= -MaxMovement)
                    player.transform.Translate(-Vector2.right * maxSpeed * Time.deltaTime);
                break;

            case type.right:
                if (player.transform.position.x <= MaxMovement)
                    player.transform.Translate(Vector2.right * maxSpeed * Time.deltaTime);
                break;
        }
    }

}
