using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class StudyClie : MonoBehaviour
{
    public bool escape = false;
    void OnTriggerEnter(Collider other)
    {
        EditorUtility.DisplayDialog("Clue", "There is a number of scribbled in a strange language notes with a large number writen and circled", "Ok");
        escape = true;
    }
}
