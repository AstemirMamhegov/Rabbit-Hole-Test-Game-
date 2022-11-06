using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuHiden : MonoBehaviour
{
    [SerializeField]
    public Image pausePanelImage;

    private void OnGUI()
    {
        pausePanelImage.gameObject.SetActive(false);
    }
}
