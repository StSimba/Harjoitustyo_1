using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Luodaan muuttujat
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);

    //Esteiden viive ja toistotahti
    private float startDelay = 2;
    private float repeatRate = 2;

    private PlayerController playerControllerScript;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnObstacle()
    {
        //Kun gameover = ep�tosi luodaan esteit� pelaajan eteen ikuisesti
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }

        //Kun gameover = tosi, printataan debug viesti
        //Ei v�ltt�m�t�n
        else if (playerControllerScript.gameOver == true)
        {
            Debug.Log("Stopping obstacle spawning!");
        }
    }
}
