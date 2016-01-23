using UnityEngine;
using System.Collections;

public class FadeScript : MonoBehaviour {

    public Texture2D fadeOutTexture;
    public float fadeSpeed = 0.8f;
    int drawDepth = -1000;
    float alpha = 1f;
    int fadeDir = -1;

    void OnGUI()
    {
        alpha += fadeDir * fadeSpeed * Time.deltaTime;
        alpha = Mathf.Clamp01(alpha);
        // set color of gui
        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.depth = drawDepth;
        GUI.DrawTexture(new Rect (0, 0, Screen.width, Screen.height) , fadeOutTexture);
        
        
    }
    // set fade direction fade in -1 and out 1
    public float Beginfade(int direction)
    {
        fadeDir = direction;
        return fadeSpeed; // return the fadespeed variable
    }
    void OnLevelWasLoaded()
    {
        Beginfade(-1);
    }
}
