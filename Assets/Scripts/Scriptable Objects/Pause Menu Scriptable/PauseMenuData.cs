using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New PauseMenu", menuName = "Pause Menu", order = 53)]
public class PauseMenuData : ScriptableObject
{
    [SerializeField]
    private string description;

    public string Description { get { return description; } }
}
