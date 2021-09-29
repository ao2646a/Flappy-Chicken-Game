using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChickenController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D myRb2d;
    public float flapForce;
    private AudioSource myAudioSource;
    //public ArrayList AudioClip;
    public Sprite spriteUp;
    public Sprite spriteDown;
    public SpriteRenderer mySpriteRenderer;


    // Start is called before the first frame update
    void Start()
    {
        myRb2d = GetComponent<Rigidbody2D>();
        myAudioSource = GetComponent<AudioSource>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = myRb2d.velocity;
        vel.x = speed;

        if (vel.y < 0)
        {
            mySpriteRenderer.sprite = spriteDown;
        }

        if (vel.y > 0)
        {
            mySpriteRenderer.sprite = spriteUp;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            vel.y = flapForce;
            myAudioSource.Play();
        }
       
        myRb2d.velocity = vel;


    }


   
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }


}
