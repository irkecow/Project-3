using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BedRoomClue : MonoBehaviour
{    void OnTriggerEnter(Collider other)
    {
        EditorUtility.DisplayDialog("Clue", "There is a dog collar on the bed pillow", "Ok");
    }
}
