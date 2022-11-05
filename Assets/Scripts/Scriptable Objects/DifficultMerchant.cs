using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DifficultMerchant : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI nameDifficult;

    [SerializeField]
    private TextMeshProUGUI description;

    [SerializeField]
    private TextMeshProUGUI letter;

    [SerializeField]
    private TextMeshProUGUI tryes;

    [SerializeField]
    private TextMeshProUGUI scores;

    public void UpdateDisplayUI(DifficultModData difficultModData)
    {
        nameDifficult.text = difficultModData.NameDifficult;
        description.text = difficultModData.Description;
        letter.text = difficultModData.Letter.ToString();
        tryes.text = difficultModData.Tryes.ToString();
        scores.text = difficultModData.Scores.ToString();
    }
}
