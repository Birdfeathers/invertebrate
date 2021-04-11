using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalBehavior : MonoBehaviour
{
    public List<DragBehavior> dragBehaviorList;
    private bool finished;
    public GameObject endscreen;
    public GameObject animalPrefab;
    public GameObject textPrefab;
    //public List<Sprite> animalSprites;
    public Animalinfo animalinfo;
    // Start is called before the first frame update
    int rand;
    int AnimalNum;

    void Start()
    {
            AnimalNum = 12;
            animalinfo = new Animalinfo();
            finished = false;
            for(int i = 0; i < AnimalNum; i++)
            {
                CreateAnimal(Animalinfo.locList[i], animalinfo.animalList[i]);
            }
    }

    // Update is called once per frame
    void Update()
    {
        bool correct = true;
        if(!finished)
        {
            if(dragBehaviorList.Count == 0) correct = false;
            for(int i = 0; i < dragBehaviorList.Count; i++)
            {
                if(!dragBehaviorList[i].staycorrect) correct = false;
            }
            if(correct)
            {
                endscreen.SetActive(true);
                finished = true;

            }
        }
    }

    public void ResetAnimals()
    {
        DeleteAnimals();
        Shuffle();
        AddAnimals();
        endscreen.SetActive(false);
        finished = false;

    }

    void DeleteAnimals()
    {
        for(int i = 0; i < dragBehaviorList.Count; i++)
        {
            Destroy(dragBehaviorList[i].gameObject);
        }
        dragBehaviorList.Clear();

    }

    void AddAnimals()
    {
        for(int i = 0; i < AnimalNum; i++)
        {
            CreateAnimal(Animalinfo.locList[i], animalinfo.animalList[i]);
        }
    }

    void CreateAnimal(Vector2 loc, Animals animal)
    {
        GameObject NewAnimal = Instantiate(animalPrefab, (Vector3) loc + transform.position, Quaternion.identity, transform);
        DragBehavior dragBehavior = NewAnimal.GetComponent<DragBehavior>();
        NewAnimal.GetComponent<SpriteRenderer>().sprite = animal.Pic;
        dragBehavior.species = animal.Species;
        dragBehavior.invert = animal.Invert;
        // add text
        GameObject text = Instantiate(textPrefab, NewAnimal.transform.position, Quaternion.identity,NewAnimal.transform);
        text.transform.position = new Vector3(text.transform.position.x, text.transform.position.y -15);
        text.GetComponent<TMPro.TextMeshProUGUI>().text = animal.Species;
        dragBehaviorList.Add(dragBehavior);

    }

    void Shuffle()
    {
        List<Animals> animalList = animalinfo.animalList;
        for(int i = animalList.Count; i > 1; i--)
        {
            rand = Random.Range(0, i);
            Animals temp = animalList[i - 1];
            animalList[i - 1] = animalList[rand];
            animalList[rand] = temp;
        }
    }


}
