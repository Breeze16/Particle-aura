using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CirclePosition
{
    public float radius = 0f;
    public float theta = 0f;
    public CirclePosition(float radius, float theta)
    {
        this.radius = radius;
        this.theta = theta;
    }
    public Vector3 generateCirclePosition(float tempz = 0)
    {
        return new Vector3(Mathf.Cos(this.theta) * this.radius, Mathf.Sin(this.theta) * this.radius, tempz);
    }
}


public class generalClasses : MonoBehaviour { }
