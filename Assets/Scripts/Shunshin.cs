using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Скрипт для перехода между сценами. Шуншин - мгновенный шаг

public class Shunshin : MonoBehaviour
{
    public void ShunshinScene(int _sceneNumber)
    {
        SceneManager.LoadScene(_sceneNumber);
    }
}
