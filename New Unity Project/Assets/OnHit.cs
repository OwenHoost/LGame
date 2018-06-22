using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHit : MonoBehaviour {

    public GameObject replaced;

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(replaced, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
