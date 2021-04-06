using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalBehavior : MonoBehaviour
{
    public List<DragBehavior> DragBehaviorList;
    private bool finished;
    public GameObject endscreen;
    public GameObject animalPrefab;
    //public List<Sprite> animalSprites;
    public Animalinfo animalinfo;
    // Start is called before the first frame update
    int rand;
    int AnimalNum = 12;

    void Start()
    {
            animalinfo = new Animalinfo();
            finished = false;
            //rand = Random.Range(0, 12);
    }

    // Update is called once per frame
    void Update()
    {
        bool correct = true;
        if(!finished)
        {
            if(DragBehaviorList.Count == 0) correct = false;
            for(int i = 0; i < DragBehaviorList.Count; i++)
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

    public void ResetAnimals()
    {
        DeleteAnimals();
        AddAnimals();
        endscreen.SetActive(false);
        finished = false;

    }

    void DeleteAnimals()
    {
        for(int i = 0; i < DragBehaviorList.Count; i++)
        {
            Destroy(DragBehaviorList[i].gameObject);
        }
        DragBehaviorList.Clear();

    }

    void AddAnimals()
    {
        Shuffle();
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
        DragBehaviorList.Add(dragBehavior);

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
