using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    private float _topBound = 30;
    private float _lowerBound = -10;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > _topBound || transform.position.z < _lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
