using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalBehavior : MonoBehaviour
{
    public DragBehavior[] DragBehaviorList;
    private bool finished;
    public GameObject endscreen;
    // Start is called before the first frame update
    void Start()
    {
            finished = false;
    }

    // Update is called once per frame
    void Update()
    {
        bool correct = true;
        if(!finished)
        {
            for(int i = 0; i < DragBehaviorList.Length; i++)
            {
                if(!DragBehaviorList[i].staycorrect) correct = false;
            }
            if(correct)
            {
                endscreen.SetActive(true);
                finished = true;

            }
        }
    }


}
