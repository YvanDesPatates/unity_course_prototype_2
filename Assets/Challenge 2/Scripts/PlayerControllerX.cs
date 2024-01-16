using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float dogCoolDown = 0.5f;

    private bool _canThrowDog = true;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && _canThrowDog)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            StartCoroutine(waitForNextDog());
        }
    }

    private IEnumerator waitForNextDog()
    {
        _canThrowDog = false;
        yield return new WaitForSeconds(dogCoolDown);
        _canThrowDog = true;
    }
}
