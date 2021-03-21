using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    //public DragBehavior[] DragBehaviorList;
    public AnimalBehavior animalBehavior;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        DragBehavior drag = other.gameObject.GetComponent<DragBehavior>();
        if(drag.invert)
        {
            
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        print("out");
    }
}
