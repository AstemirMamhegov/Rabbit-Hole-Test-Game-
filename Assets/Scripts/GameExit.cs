using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameExit : MonoBehaviour
{
   public void ExitGame()
    {
        Debug.Log("Complete");
        Application.Quit();
    }
}
