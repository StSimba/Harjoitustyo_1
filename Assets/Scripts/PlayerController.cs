using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
    
{
    //Luodaan tarvittavat muuttujat
    private Rigidbody PlayerRb;
    
    //Pelaajan tila (Ilmassa / Ei ilmassa)
    public bool isOnGround = true;

    //Animaatiot
    private Animator playerAnim;
    
    //Partikkelit
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;

    //��ni
    private AudioSource playerAudio;
    public AudioClip jumpSound;
    public AudioClip crashSound;

    //Hyppy
    public float jumpForce;
    public float gravModifier;

    //Gameover
    public bool gameOver = false;

    //Scoremanager
    private ScoreManager ScoreManager;

    private GameManager GameManager;

    //T�rm�yskoodi
    private void OnCollisionEnter(Collision collision)
    {
        //T�rm�ys maahan
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParticle.Play();
        }

        //T�rm�ys esteeseen
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            //Aiheuttaa game over tilan
            gameOver = true;
            Debug.Log("Game Over!");
            //Toistaa kuolema_animaation
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            //toistaa r�j�hdyspartikkelit
            explosionParticle.Play();
            //lopettaa multapartikkelit
            dirtParticle.Stop();
            //toistaa t�rm�ys��nen
            playerAudio.PlayOneShot(crashSound, 1.0f);
            //Lopetetaan pisteiden kertyminen
            if (ScoreManager != null) {
                ScoreManager.gameOver();
            }
            if (GameManager != null) 
            {
                GameManager.ShowGameOverScreen();
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {   
        //Ker�t��n aluksi komponentteja my�hemp�� k�ytt�� varten
        PlayerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();

        //Etsit��n scoremanager
        ScoreManager = FindObjectOfType<ScoreManager>();

        Physics.gravity *= gravModifier;

        GameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

        //Pelaajan hyppykoodi:
        if (Input.GetKeyDown(KeyCode.Space) && (isOnGround))
        {
            //liikuttaa pelaajaa
            PlayerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //m��ritt�� pelaajan tilan
            isOnGround = false;
            //aiheuttaa hyppyanimaation
            playerAnim.SetTrigger("Jump_trig");
            //Lopettaa partikkelit
            dirtParticle.Stop();
            //Toistaa ��nen
            playerAudio.PlayOneShot(jumpSound, 1.0f);
            Debug.Log("Jumping...");
        }
    }

}
