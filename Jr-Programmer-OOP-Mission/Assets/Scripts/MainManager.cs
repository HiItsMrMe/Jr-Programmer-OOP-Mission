using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainManager : MonoBehaviour
{
    public static float t;

    // Start is called before the first frame update
    void Start()
    {
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
    }


}
