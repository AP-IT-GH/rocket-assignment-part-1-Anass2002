using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI CoinPoints;
    private int theScore;

    void Start()
    {
        theScore = 0;
        CoinPoints.text = "Score: " + theScore;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            theScore += 1;
            CoinPoints.text = "Score: " + theScore;
        }
    }
}
