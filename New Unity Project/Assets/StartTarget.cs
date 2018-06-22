using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTarget : MonoBehaviour {

    public GameObject targetSpawned;

    public float MinX = -1;
    public float MaxX = 1;
    public float MinY = 0;
    public float MaxY = 10;
    public float MinZ = 2;
    public float MaxZ = 5;
    public int targetspawns = 10;

    public bool is3D = true;


    private void OnCollisionEnter(Collision collision)
    {
        int rem = 0;

        Destroy(gameObject);
        while(rem < targetspawns)
        {
            float x = Random.Range(MinX, MaxX);
            float y = Random.Range(MinY, MaxY);
            float z = Random.Range(MinZ, MaxZ);
            Instantiate(targetSpawned, new Vector3(x, y, z), Quaternion.identity);
            rem++;
        }
    }

}
