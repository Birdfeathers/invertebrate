using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animals
{
    public int Number{get; set;}
    public string Species{get; set;}
    public bool Invert{get; set;}
    public Sprite Pic{get; set;}
    public string Type{get; set;}
    public Animals(int number, string species, bool invert, Sprite pic)
    {
        Number = number;
        Species = species;
        Invert = invert;
        Pic = pic;
        //Type = type;
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
        new Animals(11, "Snake",false, Resources.Load<Sprite>("Snake")),
        new Animals(12, "Axolotl",false, Resources.Load<Sprite>("Axolotl")),
        new Animals(13, "Bee",true, Resources.Load<Sprite>("Bee")),
        new Animals(14, "Centipede",true, Resources.Load<Sprite>("Centipede")),
        new Animals(15, "Clam",true, Resources.Load<Sprite>("Clam")),
        new Animals(16, "Crocodile",false, Resources.Load<Sprite>("Crocodile")),
        new Animals(17, "Dolphin",false, Resources.Load<Sprite>("Dolphin")),
        new Animals(18, "Fish",false, Resources.Load<Sprite>("Fish")),
        new Animals(19, "Frog",false, Resources.Load<Sprite>("Frog")),
        new Animals(20, "Gorilla",false, Resources.Load<Sprite>("Gorilla")),
        new Animals(21, "Horseshoecrab",true, Resources.Load<Sprite>("Horseshoecrab")),
        new Animals(22, "Human",false, Resources.Load<Sprite>("Human")),
        new Animals(23, "Iguana",false, Resources.Load<Sprite>("Iguana")),
        new Animals(24, "Jellyfish",true, Resources.Load<Sprite>("Jellyfish")),
        new Animals(25, "Ladybug",true, Resources.Load<Sprite>("Ladybug")),
        new Animals(26, "Mite",true, Resources.Load<Sprite>("Mite")),
        new Animals(27, "Owl",false, Resources.Load<Sprite>("Owl")),
        new Animals(28, "Shrimp",true, Resources.Load<Sprite>("Shrimp")),
        new Animals(29, "Snail",true, Resources.Load<Sprite>("Snail")),
        new Animals(30, "Spider",true, Resources.Load<Sprite>("Spider1")),
        new Animals(31, "Sponge",true, Resources.Load<Sprite>("Sponge")),
        new Animals(32, "Squid",true, Resources.Load<Sprite>("Squid")),
        new Animals(33, "Starfish",true, Resources.Load<Sprite>("Starfish")),
        new Animals(34, "Stingray",false, Resources.Load<Sprite>("Stingray")),
        new Animals(35, "Turtle",false, Resources.Load<Sprite>("Turtle")),
        new Animals(36, "Seaurchin",true, Resources.Load<Sprite>("Seaurchin")),
        new Animals(37, "Spider",true, Resources.Load<Sprite>("Spider2")),
    };
    static float x = 55;
    static float y = -40;

    public static List<Vector2> locList = new List<Vector2>{
        new Vector2(x - 80, y -80),
        new Vector2(x - 40,  y - 80),
        new Vector2(x - 60, y - 40),
        new Vector2(x - 230, y + 10),
        new Vector2(x - 190, y + 10),
        new Vector2(x - 150, y + 10),
        new Vector2(x - 110, y + 10),
        new Vector2(x - 70, y + 10),
        new Vector2(x - 30, y + 10),
        new Vector2(x + 10, y + 10),
        new Vector2(x + 50, y + 10),
        new Vector2(x +90, y + 10),

    };

    //animalList.Add(animal1);
    //animalList = new List<Animals> {animal1, animal2};





}
