using UnityEngine;

public class GameManager : MonoBehaviour
{
    static int playerScore01 = 0;
    static int playerScore02 = 0;

    public GUISkin theSkin;

    public Transform theBall;

    void Start() {
        theBall = GameObject.FindWithTag("Ball").transform;
    }

    public void Score(string wallName)
    {
        if (wallName == "rightWall") {
            playerScore01 += 1;
        }
        else {
            playerScore02 += 1;
        }
    }

    void OnGUI() {
        GUI.skin = theSkin;
        GUI.Label(new Rect(Screen.width/2 - 150 - 22, 20, 100, 100), "" + playerScore01);
        GUI.Label(new Rect(Screen.width/2 + 150 - 22, 20, 100, 100), "" + playerScore02);

        if (GUI.Button(new Rect(Screen.width/2 - 121/2, 35, 121, 53), "RESET")) {
            playerScore01 = 0;
            playerScore02 = 0;

            theBall.SendMessage("ResetBall");
        }
    }
}
