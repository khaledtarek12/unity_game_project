using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenretLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zpos = 46;
    public bool creatingSection = false;
public int secNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (creatingSection == false) 
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection() {
        secNumber = Random.Range(0 , 3);
        Instantiate(section[secNumber] , new Vector3(0 , 0 , zpos) , Quaternion.identity);
        zpos += 46;
        yield return new WaitForSeconds(2);
        creatingSection = false;
    }
}
