using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    private Cube cube;
    [SerializeField]
    private Cylinder cylinder;
    [SerializeField]
    private Sphere sphere;

    public delegate void findFastestDancer();
    public static event findFastestDancer onDancingChanges;

    // Update is called once per frame
    void Update()
    {
        ToggleDance(KeyCode.A, cube);
        ToggleDance(KeyCode.S, sphere);
        ToggleDance(KeyCode.D, cylinder);
    }

    private void ToggleDance(KeyCode key, BaseShape shape)
    {
        bool danceToggled = false;

        if (Input.GetKeyDown(key) && !danceToggled)
        {
            shape.isDancing = !shape.isDancing;
            danceToggled = true;

            onDancingChanges?.Invoke();
        }
        if (Input.GetKeyUp(key))
        {
            danceToggled = false;
        }
    }
}
