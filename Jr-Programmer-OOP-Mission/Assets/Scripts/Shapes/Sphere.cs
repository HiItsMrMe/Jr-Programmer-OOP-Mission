using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : BaseShape
{
    private float danceSpeedSetting = 5f;

    protected override void Start()
    {
        danceSpeed = danceSpeedSetting;

        base.Start();
    }

    
}
