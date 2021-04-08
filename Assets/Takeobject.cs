using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Takeobject : Takable
{

    Vector3 lastPosition;
    protected void LateUpdate()
    {
        lastPosition = transform.position;
    }

    public override void OnItemReleased()
    {
        base.OnItemReleased();
        GetComponent<Rigidbody>().velocity = (transform.position - lastPosition) / Time.deltaTime;
    }


   
}
