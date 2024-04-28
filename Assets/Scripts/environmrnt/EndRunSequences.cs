using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRunSequences : MonoBehaviour
{
    public GameObject liVeCoins;
    public GameObject liVeDis;
    public GameObject endScreen;
    public GameObject fadeOut;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EndSequence());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator EndSequence() 
    {
        yield return new WaitForSeconds(5);
        liVeCoins.SetActive(false);
        liVeDis.SetActive(false);
        endScreen.SetActive(true);
        yield return new WaitForSeconds(5);
        fadeOut.SetActive(true);
    }
}
