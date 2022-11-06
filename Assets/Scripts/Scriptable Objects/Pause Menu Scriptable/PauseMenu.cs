using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    private GameEvent OnPauseSelected; // 1

    private void OnMouseEnter()
    {
        OnPauseSelected.Raise(); // 2
    }
}
