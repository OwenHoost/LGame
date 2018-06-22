using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestShoot : MonoBehaviour
{

    public float fireForce = 1f;
    public float angle = 0f;
    public GameObject Bullet;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }


    public void Shoot()
    {
        GameObject ammo = Instantiate(Bullet, transform.position, transform.rotation) as GameObject;
        Vector3 fireDirection = Quaternion.AngleAxis(angle , transform.right) * transform.forward;
        Rigidbody ammoBody = ammo.GetComponent<Rigidbody>();
        ammoBody.AddForce(fireDirection * fireForce);
    }
}