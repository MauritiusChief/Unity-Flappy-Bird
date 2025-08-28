using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdBody;
    public float flapStrength = 10f;
    public LogicScript logicLib;
    public AudioSource birdSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Find the LogicScript component in the scene
        logicLib = GameObject.FindGameObjectWithTag("LogicTag").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && logicLib.birdIsAlive && transform.position.y < 7)
        {
            birdBody.linearVelocity = Vector2.up * flapStrength;
            birdSound.Play();
        }

        if (transform.position.y < -12)
        {
            logicLib.GameOver();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(logicLib.birdIsAlive) logicLib.GameOver();
    }
}
