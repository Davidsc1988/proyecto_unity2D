using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Coin : MonoBehaviour
{

    public Score score;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
        Debug.Log("El personaje me ha tocado");
        score.totalScore += 5;
    }
}

