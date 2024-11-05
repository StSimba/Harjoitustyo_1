using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    //Luodaan muuttujat
    private Vector3 startPos;
    private float repeatWidth;

    // Start is called before the first frame update
    void Start()
    {
        //asetetaan startpos arvoksi taustan sijeinti nyt 
        //ja repeatwidth arvoksi taustan ymp‰rill‰ olevan colliderin keskikohta
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        //Jos maa / tausta menee liian kauas siirret‰‰n se takaisin alkuun 
        //= Illuusio ikuisesta taustasta / Maastosta
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
