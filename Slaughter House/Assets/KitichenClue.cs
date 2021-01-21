using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;

public class KitichenClue : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        EditorUtility.DisplayDialog("Clue","There is a large amout of animal meat in the frezer","Ok");
    }
}
