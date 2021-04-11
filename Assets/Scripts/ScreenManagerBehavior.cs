using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManagerBehavior : MonoBehaviour
{
    public List<GameObject> screens;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool Active()
    {
        for(int i = 0; i < screens.Count; i++)
        {
            if(screens[i].activeSelf == true) return true;
        }

        return false;
    }
}
