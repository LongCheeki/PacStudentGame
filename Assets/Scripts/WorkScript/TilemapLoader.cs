// using System.Collections;
// using System.Collections.Generic;
// using Sirenix.OdinInspector;
// using UnityEditor;
// using UnityEngine;
// using UnityEngine.Tilemaps;

// [ExecuteInEditMode]
// public class TilemapLoader : MonoBehaviour
// {
//     public Transform gridTransform;
//     public Tilemap tilemap;
//     public RuleTile outerTile;
//     public RuleTile innerTile;
//     public RuleTile tRuleTile;
//     public Tile tTile;
//     public GameObject PowerPelletObj;
//     public GameObject NomarlPelletObj;
//     int[,] levelMap = 
//     { 
//         {1,2,2,2,2,2,2,2,2,2,2,2,2,7}, 
//         {2,5,5,5,5,5,5,5,5,5,5,5,5,4}, 
//         {2,5,3,4,4,3,5,3,4,4,4,3,5,4}, 
//         {2,6,4,0,0,4,5,4,0,0,0,4,5,4}, 
//         {2,5,3,4,4,3,5,3,4,4,4,3,5,3}, 
//         {2,5,5,5,5,5,5,5,5,5,5,5,5,5}, 
//         {2,5,3,4,4,3,5,3,3,5,3,4,4,4}, 
//         {2,5,3,4,4,3,5,4,4,5,3,4,4,3}, 
//         {2,5,5,5,5,5,5,4,4,5,5,5,5,4}, 
//         {1,2,2,2,2,1,5,4,3,4,4,3,0,4}, 
//         {0,0,0,0,0,2,5,4,3,4,4,3,0,3}, 
//         {0,0,0,0,0,2,5,4,4,0,0,0,0,0}, 
//         {0,0,0,0,0,2,5,4,4,0,3,4,4,0}, 
//         {2,2,2,2,2,1,5,3,3,0,4,0,0,0}, 
//         {0,0,0,0,0,0,5,0,0,0,4,0,0,0}, 
//     }; 
//     void FillQuadrant(int[,] targetMap, int[,] sourceMap, int startX, int startY, bool flipX, bool flipY)
//     {
//         int rows = sourceMap.GetLength(0);
//         int cols = sourceMap.GetLength(1);

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 int targetX = flipX ? cols - 1 - j : j;
//                 int targetY = flipY ? rows - 1 - i : i;

//                 targetMap[startX + targetY, startY + targetX] = sourceMap[i, j];
//             }
//         }
//     }
    
//     [Button("toCenter")]
//     public void toCenter()
//     {
//         int rows = levelMap.GetLength(0);
//         int cols = levelMap.GetLength(1);
//         gridTransform.localPosition = new Vector3(-rows, cols, 0);
//     }
//     [Button("produceMap")]
//     public void produceMap()
//     {
//         int rows = levelMap.GetLength(0);
//         int cols = levelMap.GetLength(1);


//         int[,] fullMap = new int[rows * 2, cols * 2];


//         FillQuadrant(fullMap, levelMap, 0, 0, false, false);


//         FillQuadrant(fullMap, levelMap, 0, cols, true, false);

//         FillQuadrant(fullMap, levelMap, rows, 0, false, true);


//         FillQuadrant(fullMap, levelMap, rows, cols, true, true);
//         RenderTilemap(fullMap);
//     }
//     void RenderTilemap(int[,] map)
//     {
//         for(int i = tilemap.transform.childCount - 1;i >=0; i--)
//         {
//             DestroyImmediate(tilemap.transform.GetChild(i).gameObject);
//         }
//         // while(tilemap.transform.childCount > 0)
//         // {
//         //     DestroyImmediate(tilemap.transform.GetChild(0));
//         // }

//         int rows = map.GetLength(0);
//         int cols = map.GetLength(1);

//         for (int x = 0; x < rows; x++)
//         {
//             for (int y = 0; y < cols; y++)
//             {
//                 int tileIndex = map[x, y];
//                 switch(tileIndex)
//                 {
//                     case 1:
//                     case 2:
//                         tilemap.SetTile(new Vector3Int(x, -y, 0), outerTile);
//                         break;
//                     case 3:
//                     case 4:
//                         tilemap.SetTile(new Vector3Int(x, -y, 0), innerTile);
//                         break;
//                     case 5:
//                         GameObject pelPrefab = Instantiate<GameObject>(NomarlPelletObj);
//                         pelPrefab.transform.SetParent(tilemap.transform, false);
//                         pelPrefab.transform.position = tilemap.GetCellCenterWorld(new Vector3Int(x, -y, 0));
//                         break;
//                     case 6:
//                         GameObject powerPelPrefab = Instantiate<GameObject>(PowerPelletObj);
//                         powerPelPrefab.transform.SetParent(tilemap.transform, false);
//                         powerPelPrefab.transform.position = tilemap.GetCellCenterWorld(new Vector3Int(x, -y, 0));
//                         break;
//                     case 7:
//                         tilemap.SetTile(new Vector3Int(x, -y, 0), tRuleTile);
//                         break;
//                 }
//             }
//         }
//     }

// }
