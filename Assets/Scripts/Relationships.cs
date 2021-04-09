using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relationships : MonoBehaviour
{
    public GameObject child1;
    public GameObject child2;
    // Start is called before the first frame update
    void Start()
    {
        if(child1 != null)
        {
            Draw(transform.position, child1.transform.position, child2.transform.position);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void DrawLine(Vector3 pos1, Vector3 pos2)
    {
        // draw a line
        GameObject line = new GameObject();
        line.AddComponent<LineRenderer>();
        LineRenderer lr = line.GetComponent<LineRenderer>();
        lr.material = new Material(Shader.Find("Sprites/Default"));
        lr.material.color = Color.green;
        lr.SetWidth(.1f, .1f);
        lr.SetPosition(0, pos1);
        lr.SetPosition(1, pos2);


    }

    void Draw(Vector3 parent, Vector3 ch1, Vector3 ch2)
    {
        RectTransform rectTransform1 = child1.GetComponent<RectTransform>();
        RectTransform rectTransform2 = child2.GetComponent<RectTransform>();

        float x1 = rectTransform1.rect.width /75;
        float x2 = rectTransform2.rect.width/75;
        print(x1);

        // define all x and y coordinates used to make new points
        float midx = (parent.x + ch1.x -1)/2;
        float ch1y = ch1.y;
        float py = parent.y;
        float ch2y = ch2.y;
        float ch1x = ch1.x;
        float ch2x = ch2.x;

        // create new points to Use
        Vector3 upper  = new Vector3(midx, ch1y, 0f);
        Vector3 mid = new Vector3(midx, py, 0f);
        Vector3 lower = new Vector3(midx, ch2y, 0f);
        Vector3 newchild1 = new Vector3(ch1x - x1, ch1y, 0f);
        Vector3 newchild2 = new Vector3(ch2x - x2, ch2y, 0f);

        // Draw lines for tree
        DrawLine(parent, mid);
        DrawLine(upper, lower);
        DrawLine(upper, newchild1);
        DrawLine(lower, newchild2);
    }
}
