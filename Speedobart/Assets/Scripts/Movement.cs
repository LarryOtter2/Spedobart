using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Movement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rdbody;
    public float Speed;
    public bool isMoving;
    Vector2 movement;

    private void Start()
    {
        rdbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


        if (movement.x != 0 || movement.y != 0)
            isMoving = true;
        else
            isMoving = false;

    }

    private void FixedUpdate()
    {
        rdbody.MovePosition(rdbody.position + movement * Speed * Time.fixedDeltaTime);
    }





}
