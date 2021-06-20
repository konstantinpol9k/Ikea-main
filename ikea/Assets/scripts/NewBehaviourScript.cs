using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    public Transform _target;

    public float moveSpeed = 50f;



    void Update()
    {
        transform.Rotate(Vector3.up, Input.GetAxis("Mouse X"), Space.World);

        float forwardMove = Input.GetAxis("Vertical") * moveSpeed;
        float sideMove = Input.GetAxis("Horizontal") * moveSpeed;
        _target.position += _target.forward * forwardMove +
                            _target.right * sideMove;
    }
}
