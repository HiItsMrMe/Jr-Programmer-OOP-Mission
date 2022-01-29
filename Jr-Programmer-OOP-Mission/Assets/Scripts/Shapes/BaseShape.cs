using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseShape : MonoBehaviour
{

    public float danceSpeed { get; protected set; } = 1f;
    public bool dancing = true;

    // needs to be set in child class instance
    protected Vector3 startPosition;

    private void Update()
    {
        Dance(danceSpeed);
    }

    protected virtual void Dance(float speed)
    {
        if (dancing)
        {
            float x = MoveX(speed);
            float z = MoveZ(speed);
            transform.position = startPosition + new Vector3(x, 0, z);
        }
    }

    //ABSTRACTION START
    private float MoveX(float speed)
    {
        float x = SinOverTime(speed);
        return x;
    }

    private float MoveZ(float speed)
    {
        float z = CosOverTime(speed);
        return z;
    }

    protected float SinOverTime(float speed)
    {
        float f = Mathf.Sin(MainManager.t * speed);
        return f;
    }

    private float CosOverTime(float speed)
    {
        float f = Mathf.Cos(MainManager.t * speed);
        return f;
    }
    // ABSTRACTION END
}
