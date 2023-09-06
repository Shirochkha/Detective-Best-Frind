using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public float speed_Move = 5f;
    public float sensitivity = 5f;
    public GameObject head;

    private float _x_Move;
    private float _z_Move;
    private CharacterController _player;
    private Vector3 _move_Direction;

    void Start()
    {
        _player = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Move();
    }

    void Move()
    {
        _x_Move = Input.GetAxis("Horizontal");
        _z_Move = Input.GetAxis("Vertical");           
        if(_player.isGrounded)
        {
            _move_Direction = new Vector3 (_x_Move, 0f, _z_Move);
            _move_Direction = head.transform.TransformDirection (_move_Direction);
        }
        _move_Direction.y = -4;
        _player.Move (_move_Direction * speed_Move * Time.deltaTime);
    }
}
