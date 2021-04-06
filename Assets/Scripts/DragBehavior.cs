using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragBehavior : MonoBehaviour
{
    private bool isDragging;
    public bool invert;
    public string species;
    public bool iscorrect;
    public bool staycorrect;
    // Start is called before the first frame update
    void Start()
    {
        iscorrect = false;
        staycorrect = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDragging) {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }

    public void OnMouseDown()
    {
        isDragging = true;
    }

    public void OnMouseUp()
    {
        isDragging = false;
        if(iscorrect) staycorrect = true;
        else staycorrect = false;
    }


}
