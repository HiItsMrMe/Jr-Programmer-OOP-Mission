using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : BaseShape
{
    private float danceSpeedSetting = 5f;

    private void Start()
    {
        danceSpeed = danceSpeedSetting;
        startPosition = transform.position;
    }

    
}
