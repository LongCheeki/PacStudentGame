using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Animations;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
    }
    [MenuItem("Tools/Rename Prefab Children")]
    private static void RenameSelectedPrefabChildren()
    {
        GameObject[] selectedObjects = Selection.gameObjects;
        Debug.Log(selectedObjects.Length);
        string searchString = "PacStudent";

        foreach (GameObject selected in selectedObjects)
        {
    
     
                Transform[] children = selected.GetComponentsInChildren<Transform>(true);
    
            
                foreach (Transform child in children)
                {
                    if (child == selected.transform) continue;
                    Animator animator = child.GetComponent<Animator>();
                    if(animator != null)
                    {

                        
                        animator.runtimeAnimatorController = AssetDatabase.LoadAssetAtPath<RuntimeAnimatorController>("Assets/Sprites/Ghosts/GhostAnimContol.controller");
                    }

                }

                Debug.Log($"Renamed children of {selected.name}");

        }
    }
}
