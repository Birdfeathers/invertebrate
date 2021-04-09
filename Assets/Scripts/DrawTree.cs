using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawTree
{

            // lr.material = new Material(Shader.Find("Particles/Alpha Blended Premultiply"));
            // lr.SetColors(color, color);
            // lr.SetWidth(0.1f, 0.1f);
            // lr.SetPosition(0, start);
            // lr.SetPosition(1, end);
            // GameObject.Destroy(myLine, duration);
    void DrawLine(Vector3 pos1, Vector3 pos2)
    {
        // draw a line
        GameObject line = new GameObject();
        line.AddComponent<LineRenderer>();
        LineRenderer lr = line.GetComponent<LineRenderer>();
        lr.SetWidth(0.1f, 0.1f);
        lr.SetPosition(0, pos1);
        lr.SetPosition(1, pos2);
    }

    void Draw(Vector3 parent, Vector3 child1, Vector3 child2)
    {
        // define all x and y coordinates used to make new points
        float midx = (parent.x + child1.x)/2;
        float ch1y = child1.y;
        float py = parent.y;
        float ch2y = child2.y;

        // create new points to Use
        Vector3 upper  = new Vector3(midx, ch1y, 0f);
        Vector3 mid = new Vector3(midx, py, 0f);
        Vector3 lower = new Vector3(midx, ch2y, 0f);

        // Draw lines for tree
        DrawLine(parent, mid);
        DrawLine(upper, lower);
        DrawLine(upper, child1);
        DrawLine(lower, child2);




        // lr.material = new Material(Shader.Find("Particles/Alpha Blended Premultiply"));
        // lr.SetColors(color, color);
        // lr.SetWidth(0.1f, 0.1f);
        // lr.SetPosition(0, start);
        // lr.SetPosition(1, end);
        // GameObject.Destroy(myLine, duration);
    }
}
