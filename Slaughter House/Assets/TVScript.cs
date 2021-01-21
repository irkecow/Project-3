using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TVScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        EditorUtility.DisplayDialog("Clue", "There are book with myths about immortality on the TV", "Ok");
    }
}
