using UnityEngine;

public class MiddleTriggerScript : MonoBehaviour
{
    public LogicScript logicLib;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Find the LogicScript component in the scene
        logicLib = GameObject.FindGameObjectWithTag("LogicTag").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("BirdLayer"))
        {
            if (logicLib.birdIsAlive) logicLib.IncreaseScore(1);
        }
    }
}
