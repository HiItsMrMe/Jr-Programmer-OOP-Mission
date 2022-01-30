using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainUIHandler : MonoBehaviour
{
    [SerializeField]
    private Text fastestDancer;

    public static List<BaseShape> UIShapeList;

    private void Awake()
    {
        UIShapeList = new List<BaseShape>();
        PlayerInput.onDancingChanges += displayFastestDancer;
    }

    private void displayFastestDancer()
    {
        SortedList sortedDancers = OrderDancingShapes();

        if (sortedDancers.Count > 0)
        {
            fastestDancer.text = "The fastest dancer is: " + sortedDancers.GetByIndex(sortedDancers.Count - 1);
            return;
        }

        fastestDancer.text = "Nobody is dancing!";
    }

    private SortedList OrderDancingShapes()
    {
        SortedList sortedDancers = new SortedList();

        foreach (BaseShape shape in UIShapeList)
        {
            if (shape.isDancing)
            {
                sortedDancers.Add(shape.danceSpeed, shape.name);
            }
        }
        return sortedDancers;
    }
}
