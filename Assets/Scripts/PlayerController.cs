using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class PlayerController : MonoBehaviour {
    public GameObject deatparticles;
    private ScoreSystem displayHiScore;
    public AudioClip clip;
    public static bool PlayAnim = false;

    // Use this for initialization
    void Start () {

        displayHiScore = FindObjectOfType<ScoreSystem>();
        ScoreSystem.checker = true;

    }
    void Awake()
    {
          }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "enemy")
        {
            AudioSource.PlayClipAtPoint(clip, new Vector3(0, 0, 0));
            EnemyGenerator1.stopEnemy = false;
            Die();
            Destroy(gameObject, 3f);
            Invoke("EndGame", 2.8f);
          
        }
      }
      void Die()
      {
          PlayAnim = true;
          ScoreSystem.checker = false;  
          Instantiate(deatparticles, transform.position, Quaternion.identity);

      }
    void EndGame()
    {
        //float fadeTime = GameObject.Find("ScriptHolder").GetComponent<FadeScript>().Beginfade(1);
        // yield return new WaitForSeconds(fadeTime);
        displayHiScore.scoreCounter = 0;
        Application.LoadLevel(2);
    }
  }
