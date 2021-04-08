using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forceplanet : MonoBehaviour
{
    public Rigidbody sun;
    public int factor;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody[] Rigidbodies = FindObjectsOfType(typeof(Rigidbody)) as Rigidbody[];

        for (int x = 0; x < Rigidbodies.Length; x++)
        {
            if (Rigidbodies[x] != sun)
            {
                Rigidbodies[x].AddForce((sun.gameObject.transform.position.z - Rigidbodies[x].transform.position.z)*factor, 0, 0);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
