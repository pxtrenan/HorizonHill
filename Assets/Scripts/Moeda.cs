﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moeda : MonoBehaviour {

    //public AudioSource som2;
    //public AudioClip soundCoin;

    private void OnTriggerEnter2D(Collider2D other)
    {
     
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            LevelManager.levelManager.SetCoins();

            //som2.PlayOneShot(soundCoin);

        }
        if (other.CompareTag("Player2"))
        {
            gameObject.SetActive(false);
            LevelManager.levelManager.SetCoins();

            //som2.PlayOneShot(soundCoin);

        }

    }
}
