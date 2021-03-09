using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilecode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //setTile(zero,)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}/*
public class HighlightInFront : MonoBehaviour
{
    public Tile highlightTile;
    public Tilemap highlightMap;
 
    private Vector3Int previous;
 
    // do late so that the player has a chance to move in update if necessary
    private void LateUpdate()
    {
        // get current grid location
        Vector3Int currentCell = highlightMap.WorldToCell(transform.position);
        // add one in a direction (you'll have to change this to match your directional control)
        currentCell.x += 1;
 
        // if the position has changed
        if(currentCell != previous)
        {
            // set the new tile
            highlightMap.SetTile(currentCell, highlightTile);
 
            // erase previous
            highlightMap.SetTile(previous, null);
 
            // save the new position for next frame
            previous = currentCell;
        }
    }
}
 [Serializable]
 public class TileType
 {
     public int id;
     public string name;
     public double hardness;
 
     public static TileType CreateFromJSON(string jsonString)
     {
         return JsonUtility.FromJson<TileType>(jsonString);
     }
 }
 
 public class TileTypeLoader
 {
     public IEnumerable<TileType> LoadTileTypes()
     {
         var tileTypes = new List<TileType>();
         var tileTypeStrings = File.ReadAllLines("C:/path/to/tile/type/file.json");
         foreach(var tileTypeString in tileTypeStrings)
         {
             var tileType = TileType.CreateFromJSON(tileTypeString);
             tileTypes.Add(tileType);
         }
 
         return tileTypes;
     }
 }*/