using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabbi : MonoBehaviour
{
    public int GRABI;
    public float grabPower = 10.0f;
    public float throwPower = 10f;   
    public float RayDistance = 30.0f;   

    private bool Grab = false;   
    private bool Throw = false;   
    public Transform offset;
    public Camera Playercamera;
    RaycastHit hit;   //луч


    private void Start()
    {
        GRABI = 0;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Ray ray = Playercamera.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out hit, RayDistance);
            if (hit.rigidbody)
            {
                GRABI = GRABI + 1;
                switch (GRABI)
                {
                    case 1:
                        Grab = true;
                        break;
                    case 2:
                        Grab = false;
                        break;
                    default:
                        break;
                }
                if (GRABI == 3)
                {
                    GRABI = 0;
                }
                if (Grab == false)
                {
                    GRABI = 0;
                }
            }
            Debug.Log(GRABI);
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (Grab)
            {
                GRABI = 0;
            }
        }

        if (Input.GetMouseButtonDown(0))
        {//если нажата лев кн мыши
            if (Grab)
            {
                Grab = false;
                Throw = true;
            }
        }

        if (Grab)
        {
            if (hit.rigidbody)
            {
                hit.rigidbody.velocity = (offset.position - (hit.transform.position + hit.rigidbody.centerOfMass)) * grabPower;

            }
        }

        if (Throw)
        {
            if (hit.rigidbody)
            {
                hit.rigidbody.velocity = Playercamera.ScreenPointToRay(Input.mousePosition).direction * throwPower;
                Throw = false;
            }
        }
    }

    private void Grabb()
    {
        Ray ray = Playercamera.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out hit, RayDistance);
        if (hit.rigidbody)
        {
            Grab = true;
        }
    }
}