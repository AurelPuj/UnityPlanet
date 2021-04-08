using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public Rigidbody sun;
    IEnumerator Routine()
    {
        while (true)
        {
            Rigidbody[] Rigidbodies = FindObjectsOfType(typeof(Rigidbody)) as Rigidbody[];

            for (int x = 0; x < Rigidbodies.Length; x++)
            {
                if (Rigidbodies[x] != sun)
                {
                    Rigidbodies[x].AddForce((sun.gameObject.transform.position - Rigidbodies[x].transform.position) * (sun.mass / Vector3.Distance(Rigidbodies[x].transform.position, sun.transform.position)));
                    yield return new WaitForSeconds(0);
                }
            }

            yield return new WaitForSeconds(0);
        }
    }
    // Update is called once per frame
    void Awake()
    {
        StartCoroutine(Routine());
    }
}
