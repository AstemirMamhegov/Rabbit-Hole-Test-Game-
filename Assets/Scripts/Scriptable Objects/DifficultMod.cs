using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultMod : MonoBehaviour
{
    [SerializeField]
    private GameEvent OnDifficcultSelected; // 1

    private void OnMouseDown()
    {
        OnDifficcultSelected.Raise(); // 2
    }
}
