﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandling : MonoBehaviour
{
    //PROGRAMMED BT
    // LEE FEARNETT
    // JACK PROCTER

    public GameObject Player;
    CharacterController charControls;
    public GameObject Camera;
    public GameObject camAxisCorrected;

    public float speed = 3f;
    float gravity = 0f;

    private void Start()
    {
        camAxisCorrected = GameObject.FindGameObjectWithTag("CamChild");
        charControls = Player.GetComponent<CharacterController>();
        Player.transform.position = GameObject.FindGameObjectWithTag("Spawn1").transform.position;
    }

    void Update()
    {
        newMove();
    }

    void newMove()
    {
        //BASIC MOVEMENT
        float xAxis = Input.GetAxisRaw("Horizontal");
        float zAxis = Input.GetAxisRaw("Vertical");

        var forward = camAxisCorrected.transform.forward;
        var right = camAxisCorrected.transform.right;

        Vector3 normalisedMove = new Vector3(xAxis, 0, zAxis);
        normalisedMove = (right * xAxis) + (forward * zAxis);
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
