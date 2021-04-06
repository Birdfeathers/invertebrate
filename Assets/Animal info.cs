using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animals
{
    public int Number{get; set;}
    public string Species{get; set;}
    public bool Invert{get; set;}
    public Sprite Pic{get; set;}
    public Animals(int number, string species, bool invert, Sprite pic)
    {
        Number = number;
        Species = species;
        Invert = invert;
        Pic = pic;
    }
}

public class Animalinfo
{
    //Start is called before the first frame update

    //var sprite = Resources.Load<Sprite>("Dragonfly");
    public  List<Animals> animalList = new List<Animals>{

        new Animals(0, "Dragonfly",true, Resources.Load<Sprite>("Dragonfly")),
        new Animals(1, "Hummingbird",false, Resources.Load<Sprite>("Hummingbird")),
        new Animals(2, "Lobster",true, Resources.Load<Sprite>("Lobster")),
        new Animals(3, "Millepede",true, Resources.Load<Sprite>("Millipede")),
        new Animals(4, "Moth",true, Resources.Load<Sprite>("Moth")),
        new Animals(5, "Octopus",true, Resources.Load<Sprite>("Octopus")),
        new Animals(6, "Salamander",false, Resources.Load<Sprite>("Salamander")),
        new Animals(7, "Shark",false, Resources.Load<Sprite>("Shark")),
        new Animals(8, "Spider",true, Resources.Load<Sprite>("Spider")),
        new Animals(9, "Squirrel",false, Resources.Load<Sprite>("Squirrel")),
        new Animals(10, "Coral",true, Resources.Load<Sprite>("Coral")),
        new Animals(11, "Snake",false, Resources.Load<Sprite>("Snake"))
    };

    public static List<Vector2> locList = new List<Vector2>{
        new Vector2(-30, -110),
        new Vector2(10, -110),
        new Vector2(-10, -70),
        new Vector2(-180, -20),
        new Vector2(-140, -20),
        new Vector2(-100, -20),
        new Vector2(-60, -20),
        new Vector2(-20, -20),
        new Vector2(20, -20),
        new Vector2(60, -20),
        new Vector2(100, -20),
        new Vector2(140, -20),

    };

    //animalList.Add(animal1);
    //animalList = new List<Animals> {animal1, animal2};





}
