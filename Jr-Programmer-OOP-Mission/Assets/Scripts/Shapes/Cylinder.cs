using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : BaseShape
{

    private void Start()
    {
        startPosition = transform.position;
    }
    protected override void Dance(float speed)
    {
        if (dancing)
        {
            MoveY();
        }
    }

    private void MoveY()
    {
        transform.position = startPosition + Vector3.up * (1 + SinOverTime(1f));
    }
}
