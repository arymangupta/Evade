using UnityEngine;
using System.Collections;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]
public class ScoreSystem : MonoBehaviour {
    float currentHighScore;
    public static bool checker=true;
    public float scoreCounter;
    public Text scoreText;
    public Text HighScoreText;
    public int scoreValue;
    public static ScoreSystem control;
    public float getScore;
    bool a = true;

    public AudioClip clip;
    // Use this for initialization
    void Awake() // for object persistence throught the all scene
    {
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }
        currentHighScore = InputData.highscore;
    }
	void Start () {
      //  print(InputData.highscore);
    }
	
	// Update is called once per frame
	void Update () {
        if (checker)
        {
            scoreCounter += (scoreValue * Time.deltaTime);
            PlayerPrefs.SetFloat("CurrentScore", scoreCounter);
            if (PlayerPrefs.GetFloat("CurrentScore") !=0)
            {
                getScore = Mathf.Round(PlayerPrefs.GetFloat("CurrentScore"));
                InputData.PlayerKaScore = (int)getScore;
                
            }
            if(scoreCounter > currentHighScore)
            {
                if (a) { AudioSource.PlayClipAtPoint(clip, new Vector3(0, 0, 0)); a = false; }
                 
                currentHighScore = scoreCounter;
                
            }
        }
        scoreText.text = "Score: "+Mathf.Round(scoreCounter).ToString(); //GUI for current score
        HighScoreText.text = "High Score: "+Mathf.Round(currentHighScore).ToString(); //Gui for highsocre
	}
}
