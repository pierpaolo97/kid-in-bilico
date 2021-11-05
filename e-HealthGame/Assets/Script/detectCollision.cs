using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class detectCollision : MonoBehaviour
{

    public int score = 0;
    public Text scoreText;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Risposta")
        {
           
            Debug.Log("Risposta data");
            
        }

        if (collision.transform.CompareTag("True"))
        {
            score += 1;
            scoreText.text = "Score:" + score.ToString();
        }

        if (collision.transform.CompareTag("False"))
        {
            Debug.Log("Hai sbagliato coglionazzo");
        }

        if (collision.transform.CompareTag("False"))
        {
            Debug.Log("colpito Bordi");
        }
        

    }
}
