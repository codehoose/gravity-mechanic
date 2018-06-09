using UnityEngine;
using UnityEngine.Tilemaps;

public class TouchBlock : MonoBehaviour
{
    public Tilemap pickupBlocks;

    public GameController gameController;
    
	void Update ()
    {
        var playerCellPos = pickupBlocks.WorldToCell(transform.position);

        var block = pickupBlocks.GetTile(playerCellPos);
        if (block != null)
        {
            pickupBlocks.SetTile(playerCellPos, null);
            gameController.PickUpKey();
        }
	}
}
