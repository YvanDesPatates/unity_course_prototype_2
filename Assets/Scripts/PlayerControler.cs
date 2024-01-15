using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed = 10.0f;
    public float xRange = 10f;
    public GameObject projectilPrefab;
    
    private float _horizontalInput;

    // Update is called once per frame
    void Update()
    {
        float xPosition = transform.position.x;
        if (xPosition < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (xPosition > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        else
        {
            _horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(_horizontalInput * speed * Time.deltaTime * Vector3.right);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilPrefab, transform.position, projectilPrefab.transform.rotation);
        }
    }
}
