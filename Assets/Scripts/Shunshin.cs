using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//������ ��� �������� ����� �������. ������ - ���������� ���

public class Shunshin : MonoBehaviour
{
    public void ShunshinScene(int _sceneNumber)
    {
        SceneManager.LoadScene(_sceneNumber);
    }
}
