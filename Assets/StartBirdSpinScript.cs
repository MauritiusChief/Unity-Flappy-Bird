using UnityEngine;

public class StartBirdSpinScript : MonoBehaviour
{
    public float rotationSpeed = 90f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime * Vector3.forward);
    }
}
