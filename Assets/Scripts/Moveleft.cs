using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveleft : MonoBehaviour
{
    //Luodaan muuttujat
    private float speed = 30;
    private PlayerController playerControllerScript;
    private float leftBound = -20;

    // Start is called before the first frame update
    void Start()
    {
        //Kerätään komponentteja
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Gameover tila = Epätosi, jatketaan asioiden siirtämistä
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        //Gameover tila = Tosi, Printataan debug viesti
        //Ei välttämätön
        //else if (playerControllerScript.gameOver == true) 
        //{
        //    Debug.Log("Stopping Scrolling!");
        //}
        //Kommentoitu pois sillä se aktiivisena täyttää koko consolen ilmoituksilla

        //Jos este menee pelaajan näkökentän ulkopuolelle tuhotaan se jotta pelistä ei tule memory leak :D
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }

    }
}