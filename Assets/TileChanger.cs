using UnityEngine;
using UnityEngine.Tilemaps;

public class TileChanger : MonoBehaviour
{
   public Tilemap Tilemap;
   public TileBase GreenTile;
   public TileBase BlackTile;
   public TileBase WhiteTile;
   public Camera Camera;

   private void Update()
   {
      if (Input.GetMouseButtonDown(0))
      {
         var position = Camera.ScreenToWorldPoint(Input.mousePosition);
         var cellCoordinate = Tilemap.WorldToCell(position);
         var tile = Tilemap.GetTile(cellCoordinate);

         if (tile != null)
         {
            if (tile == GreenTile)
            {
               Tilemap.SetTile(cellCoordinate, BlackTile);
            }

            if (tile == BlackTile)
            {
               Tilemap.SetTile(cellCoordinate, WhiteTile);
            }

            if (tile == WhiteTile)
            {
               Tilemap.SetTile(cellCoordinate, GreenTile);
            }
         }
      }
   }
}
