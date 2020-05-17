using UnityEngine;

public class GameManager : MonoBehaviour
{
    static int playerScore01 = 0;
    static int playerScore02 = 0;

    public GUISkin theSkin;

    public void Score(string wallName)
    {
        if (wallName == "rightWall") {
            playerScore01 += 1;
        }
        else {
            playerScore02 += 1;
        }
        Debug.Log("Player Score 1 is " + playerScore01);
        Debug.Log("Player Score 2 is " + playerScore02);
    }

    void OnGUI() {
        GUI.skin = theSkin;
        GUI.Label(new Rect(Screen.width/2 - 150, 20, 100, 100), "" + playerScore01);
        GUI.Label(new Rect(Screen.width/2 + 150, 20, 100, 100), "" + playerScore02);
    }
}
