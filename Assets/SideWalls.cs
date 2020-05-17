using UnityEngine;

public class SideWalls : MonoBehaviour
{
    public GameManager gm;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.name == "Ball")
        {
            string wallName = transform.name;
            gm.Score(wallName);
            hitInfo.gameObject.SendMessage("ResetBall");
        }
    }
}
