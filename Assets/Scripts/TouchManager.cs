using UnityEngine;
using System.Collections;

public class TouchManager : MonoBehaviour {

    public static bool guiTouch = false;
    public void InputTouch(GUITexture texture)
    {
        if (texture.HitTest(Input.GetTouch(0).position))
        {
            switch (Input.GetTouch(0).phase)
            {
                case TouchPhase.Began:
                    SendMessage("OnFirstTouchBegan");
                    SendMessage("OnFirstTouch");
                    guiTouch = true;
                    break;
                case TouchPhase.Moved:
                    SendMessage("OnFirstTouchMoved");
                    SendMessage("OnFirstTouch");
                    guiTouch = true;
                    break;
                case TouchPhase.Stationary:
                    SendMessage("OnFirstTouchStationary");
                    SendMessage("OnFirstTouch");
                    guiTouch = true;
                    break;

                case TouchPhase.Ended:
                    SendMessage("OnFirstTouchEnded");
                    guiTouch = false;
                    break;
            }
        }

        if (texture.HitTest(Input.GetTouch(1).position))
        {
            switch (Input.GetTouch(1).phase)
            {
                case TouchPhase.Began:
                    SendMessage("OnSecondTouchBegan");
                    SendMessage("OnSecondTouch");
                    break;
                case TouchPhase.Moved:
                    SendMessage("OnSecondTouchMoved");
                    SendMessage("OnSecondTouch");
                    break;
                case TouchPhase.Stationary:
                    SendMessage("OnSecondTouchStationary");
                    SendMessage("OnSecondTouch");
                    break;

                case TouchPhase.Ended:
                    SendMessage("OnSecondTouchEnded");
                    break;
            }
        }

        if (texture.HitTest(Input.GetTouch(2).position))
        {
            switch (Input.GetTouch(2).phase)
            {
                case TouchPhase.Began:
                    SendMessage("OnThirdTouchBegan");
                    SendMessage("OnThirdTouch");
                    break;
                case TouchPhase.Moved:
                    SendMessage("OnThirdTouchMoved");
                    SendMessage("OnThirdTouch");
                    break;
                case TouchPhase.Stationary:
                    SendMessage("OnThirdTouchStationary");
                    SendMessage("OnThirdTouch");
                    break;

                case TouchPhase.Ended:
                    SendMessage("OnThirdTouchEnded");
                    break;
            }
        }
    }
}
