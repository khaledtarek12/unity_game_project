using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinFx;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other) {
        coinFx.Play();
        this.gameObject.SetActive(false);
    }
}
