using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    public Text timeText;
    public float timeStart = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeStart += Time.deltaTime;
        timeText.text = "Time: " + Mathf.Round(timeStart).ToString();
    }
}
