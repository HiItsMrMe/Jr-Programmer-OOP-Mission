using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : BaseShape
{

    private void Start()
    {
        startPosition = transform.position;
    }

    //POLYMORPHISM START
    protected override void Dance(float speed)
    {
        if (isDancing)
        {
            MoveY();
        }
    }
    //POLYMORPHISM END

    private void MoveY()
    {
        transform.position = startPosition + Vector3.up * (1 + SinOverTime(1f));
    }
}
