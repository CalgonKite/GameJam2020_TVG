using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandling : MonoBehaviour
{
    //PROGRAMMED BT
    // LEE FEARNETT
    // JACK PROCTER

    public GameObject Player;
    CharacterController charControls;

    public float speed = 3f;
    float gravity = 0f;

    private void Start()
    {
        charControls = Player.GetComponent<CharacterController>();
    }

    void Update()
    {
        newMove();
    }

    void newMove()
    {
        //BASIC MOVEMENT
        float xAxis = Input.GetAxis("Horizontal");
        float zAxis = Input.GetAxis("Vertical");

        Vector3 normalisedMove = new Vector3(xAxis, 0, zAxis);
        normalisedMove = charControls.transform.right * xAxis + charControls.transform.forward * zAxis;
        Vector3 moveInput = normalisedMove.normalized * speed * Time.deltaTime;

        //GRAVITY
        if (charControls.isGrounded) { gravity = 0f; }
        else
        {
            gravity += 0.05f;
            gravity = Mathf.Clamp(gravity, 1f, 15f);
        }

        Vector3 gravityFall = Vector3.down * gravity * Time.deltaTime;

        charControls.Move(moveInput + gravityFall);
    }
}
