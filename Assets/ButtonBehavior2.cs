using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior2 : MonoBehaviour
{
    public GameObject panel;
    public GameObject open;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Close()
    {
        panel.SetActive(false);
    }

    public void Open()
    {
        open.SetActive(true);
    }


}
