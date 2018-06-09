using UnityEngine;
using UnityEngine.Tilemaps;

public class GameController : MonoBehaviour
{
    public int numberOfKeys = 1;

    public Tilemap lockedDoor;

    public CanvasGroup canvas;

    public void PickUpKey()
    {
        if (numberOfKeys == 0)
            return;

        numberOfKeys--;
        if (numberOfKeys <= 0)
        {
            UnlockTheRoom();
        }
    }

    public void EndOfLevel()
    {
        canvas.alpha = 1f;
    }

    void UnlockTheRoom()
    {
        lockedDoor.gameObject.SetActive(false);
    }
}
