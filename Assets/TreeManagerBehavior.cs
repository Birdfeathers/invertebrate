using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeManagerBehavior : MonoBehaviour
{
    public List<Relationships> treeList;
    public ScreenManagerBehavior screens;
    bool hidden;
    // Start is called before the first frame update
    void Start()
    {
        hidden = false;
    }

    // Update is called once per frame
    void Update()
    {
        // hide screens
        bool active = screens.Active();
        if(!hidden && active)
        {
            for(int i = 0; i < treeList.Count; i++)
            {
                treeList[i].Hide();
            }
            hidden = true;
        }

        if(hidden && !active)
        {
            for(int i = 0; i < treeList.Count; i++)
            {
                treeList[i].Reveal();
            }
            hidden = false;
        }




    }


}
