using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Takable : MonoBehaviour
{

	bool isPickedUp;

	public virtual void OnItemPickedUp(Transform holder)
	{ 
		isPickedUp = true;
		transform.SetParent(holder, true);
	}

	public virtual void OnItemReleased()
	{
		isPickedUp = false;
		transform.SetParent(null, true);
	}

	
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
