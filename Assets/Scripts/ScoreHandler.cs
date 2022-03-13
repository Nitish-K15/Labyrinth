using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    public int maxPellets;
    public GameObject finalPellet;

    private void OnEnable()
    {
        Ball.onEat += Calculate;
    }

    private void OnDisable()
    {
        Ball.onEat -= Calculate;
    }

    void Calculate()
    {
        maxPellets = maxPellets - 1;
        if(maxPellets <= 0)
        {
            finalPellet.SetActive(true);
        }
    }
}
