using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : BaseShape
{
    private float danceSpeedSetting = 1f;

    private void Start()
    {
        danceSpeed = danceSpeedSetting;
        startPosition = transform.position;
    }

}
