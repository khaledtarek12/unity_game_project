using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public String ParentName;
    // Start is called before the first frame update


    // Update is called once per frame
    void Start()
    {
        ParentName = transform.name;
        StartCoroutine(DestroyClone());
    }

    IEnumerator DestroyClone() {
        yield return new WaitForSeconds(60);
        if (ParentName == "Section(Clone)" || ParentName == "Section (Clone)")
        {
            Destroy(gameObject);
        }
    }
}
