using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.WSA.Input;
using UnityEngine;

public class Shooter : MonoBehaviour {

    public float fireForce = 2000f;
    public float angle = 0f;
    public GameObject Bullet;
    public float maxDistance = 15f;
    private TappedEventArgs args;
   
    private GestureRecognizer gestureRecognizer;
    // Use this for initialization
    void Awake () {
        /*line = gameObject.GetComponent<LineRenderer>();
        line.enabled = false;*/
        gestureRecognizer = new GestureRecognizer();
        gestureRecognizer.Tapped += OnTappedEvent;
        gestureRecognizer.SetRecognizableGestures(GestureSettings.Tap);
        gestureRecognizer.StartCapturingGestures();
    }

    private void Update()
    {
     
    }

    private void OnTappedEvent(TappedEventArgs args)
    {
        Shoot();
    }

    public void Shoot()
    {
        GameObject ammo = Instantiate(Bullet, transform.position, transform.rotation) as GameObject;
        Vector3 fireDirection = Quaternion.AngleAxis(angle, transform.right) * transform.forward;
        Rigidbody ammoBody = ammo.GetComponent<Rigidbody>();
        ammoBody.AddForce(fireDirection * fireForce);
    }

}
