using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainManager : MonoBehaviour
{
    public static float t;

    [SerializeField]
    private Cube cube;
    [SerializeField]
    private Cylinder cylinder;
    [SerializeField]
    private Sphere sphere;

    // Start is called before the first frame update
    void Start()
    {
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        ToggleDance(KeyCode.A, cube);
        ToggleDance(KeyCode.S, sphere);
        ToggleDance(KeyCode.D, cylinder);

    }

    private void ToggleDance(KeyCode key, BaseShape shape)
    {
        bool danceToggled = false;

        if (Input.GetKeyDown(key) && !danceToggled)
        {
            shape.dancing = !shape.dancing;
            danceToggled = true;
        }
        if (Input.GetKeyUp(key))
        {
            danceToggled = false;
        }
    }
}
