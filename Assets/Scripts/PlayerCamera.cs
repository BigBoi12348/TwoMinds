using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Vector2 turn;
    public float sensitivity = .5f;
    public Vector3 deltaMove;
    public float speed = 1;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;

        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }

    //public float speed;

    //public float clampValueHorizontal;
    //public float clampValueVertical;

    //private float rotationX;
    //private float rotationY;

    //void Update()
    //{
    //    rotationX += speed * Input.GetAxis("Mouse Y");
    //    rotationX += speed * Input.GetAxis("Mouse X");

    //    rotationX = Mathf.Clamp(rotationX, -clampValueVertical, clampValueVertical);

    //    rotationY = Mathf.Clamp(rotationY, - clampValueHorizontal, clampValueHorizontal);

    //    transform.eulerAngles = new Vector3(rotationX, rotationY, 0);

    //}
}
