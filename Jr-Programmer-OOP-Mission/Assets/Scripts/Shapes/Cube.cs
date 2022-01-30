using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : BaseShape
{
    private float danceSpeedSetting = 1.5f;

    protected override void Start()
    {
        danceSpeed = danceSpeedSetting;

        base.Start();
    }

}
