using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextEdit : MonoBehaviour
{
    private TextMeshProUGUI txtMPU;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        txtMPU = gameObject.GetComponent<TextMeshProUGUI>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        txtMPU.text = score.ToString();
        score++;
    }
}
