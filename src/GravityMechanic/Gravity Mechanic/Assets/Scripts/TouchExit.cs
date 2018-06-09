using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TouchExit : MonoBehaviour
{
    public Tilemap exitBlock;

    public GameController gameController;

    void Update ()
    {
        var playerCellPos = exitBlock.WorldToCell(transform.position);

        var block = exitBlock.GetTile(playerCellPos);
        if (block != null)
        {
            gameController.EndOfLevel();
        }
    }
}
