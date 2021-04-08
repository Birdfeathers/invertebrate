using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehavior1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Loadiv()
    {
        SceneManager.LoadScene("Invert");
    }

    public void Loads()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Loadm()
    {
        SceneManager.LoadScene("Meta");
    }

    public void Loadre()
    {
        SceneManager.LoadScene("Resources");
    }

    public void Loadro()
    {
        SceneManager.LoadScene("Role");
    }

    public void Loadt()
    {
        SceneManager.LoadScene("Type");
    }

    public void Loadc()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Loadp()
    {
        SceneManager.LoadScene("PictureCredits");
    }

    public void Loadii()
    {
        SceneManager.LoadScene("Invertebrate");
    }

    public void Loadv()
    {
        SceneManager.LoadScene("Vertebrates");
    }

    public void Loadlv()
    {
        SceneManager.LoadScene("Land Vertebrates");
    }

    public void Loada()
    {
        SceneManager.LoadScene("Arthropods");
    }
}
