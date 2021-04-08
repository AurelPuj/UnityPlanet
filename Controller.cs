using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

	Rigidbody pickedUpItem;
	public void PickUp()
	{
		Collider[] hitItems = Physics.OverlapSphere(transform.position, 0.3f);
		pickedUpItem = hitItems[0].GetComponent<Rigidbody>();
		pickedUpItem.SendMessage("OnItemPickedUp", transform);
	}

	public void Release()
	{
		pickedUpItem.SendMessage("OnItemReleased");
		pickedUpItem = null;
	}

	// Start is called before the first frame update
	void Start()
	{
		PickUp();
	}

	// Update is called once per frame
	void Update()
	{
	}
}
