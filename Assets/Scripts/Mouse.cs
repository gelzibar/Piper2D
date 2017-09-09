using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{

    private Rigidbody myRigidbody;
    private Camera myCamera;
    private Vector3 mouseVec;
    private Event mouseEvent;

    public bool isLive;

    void Start()
    {
        OnStart();
    }

    void FixedUpdate()
    {
        OnFixedUpdate();
    }

    void Update()
    {
        OnUpdate();
    }

    void OnGUI()
    {
    }

    void OnStart()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myCamera = Camera.main;
        mouseVec = new Vector3();

		Cursor.visible = false;
        isLive = true;
    }

    void OnFixedUpdate()
    {
        if(isLive) {
            // Set the rigidbody to the translated position of the mouse position. Y at 0 due to no verticle movement.
            myRigidbody.MovePosition(new Vector3(mouseVec.x, mouseVec.y, myRigidbody.position.z));
        } else {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
    }

    void OnUpdate()
    {
		// Construct the Vector3 for ScreenToWorldPoint. See Unity Reference for instruction.
        Vector3 screenPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, myCamera.transform.position.y);
        mouseVec = myCamera.ScreenToWorldPoint(screenPos);
    }

}
