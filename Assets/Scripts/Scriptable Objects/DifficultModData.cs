using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "New DifficultMod", menuName = "Difficult Mod Data", order = 51)]
public class DifficultModData : ScriptableObject
{
    [SerializeField]
    private string nameDifficult;

    [SerializeField]
    private string description;

    [SerializeField]
    private Sprite icons;

    [SerializeField]
    private int letter;

    [SerializeField]
    private int tryes;

    [SerializeField]
    private int scores;


    public string NameDifficult { get { return nameDifficult; } }

    public string Description { get { return description; } }

    public Sprite Icon { get { return icons; } }

    public int Letter { get { return letter; } }

    public int Tryes { get { return tryes; } }

    public int Scores { get { return scores; } }


}
