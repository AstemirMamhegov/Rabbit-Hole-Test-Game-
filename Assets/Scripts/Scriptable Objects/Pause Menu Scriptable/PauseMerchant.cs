using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PauseMerchant : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI description; // 2

    public void UpdateDisplayUI(PauseMenuData pauseMenuData)
    {
        description.text = pauseMenuData.Description;
    }
}
