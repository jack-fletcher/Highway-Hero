using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficMovement : baseMovement
{

    private void Update()
    {
        Movement();
    }

    public override void Initialise()
    {
        base.Initialise();
    }
    protected override void Movement()
    {
        base.Movement();
        speed = 30f;
    }
}