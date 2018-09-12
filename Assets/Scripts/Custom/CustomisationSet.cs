﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomisationSet : MonoBehaviour
{
    #region Variables
    [Header("Texture List")]
    //Texture2D List for skin,hair, mouth, eyes
    public List<Texture2D> skin = new List<Texture2D>();
    public List<Texture2D> hair = new List<Texture2D>();
    public List<Texture2D> mouth = new List<Texture2D>();
    public List<Texture2D> eyes = new List<Texture2D>();
    public List<Texture2D> clothes = new List<Texture2D>();
    public List<Texture2D> armour = new List<Texture2D>();
    [Header("Index")]
    public int skinIndex;
    public int hairIndex, mouthIndex, eyesIndex, clothesIndex, armourIndex;
    //index numbers for our current skin, hair, mouth, eyes textures

    [Header("Renderer")]
    public Renderer character;
    //renderer for our character mesh so we can reference a material list

    [Header("Max Index")]
    public int skinMax;
    public int hairMax, mouthMax, eyesMax, clothesMax, armourMax;

    //max amount of skin, hair, mouth, eyes textures that our lists are filling with

    [Header("Character Name")]
    public string charName = "Adventurer";
    //name of our character that the user is making
    [Header("Stats")]
    //base stats for player
    public int str;
    public int dex, charisma, con, intel, wis;
    //points in which we use to increase our stats
    public int points = 10;
    public CharacterClass charClass = CharacterClass.Barbarian;
    #endregion

    #region Start
    //in start we need to set up the following
    private void Start()
    {
        #region for loop to pull textures from file
        //for loop looping from 0 to less than the max amount of skin textures we need
        for (int i = 0; i < skinMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for Skin_#
            Texture2D temp = Resources.Load("Character/Skin_" + i) as Texture2D;
            skin.Add(temp);
            //add our temp texture that we just found to the skin List
        }
        //for loop looping from 0 to less than the max amount of hair textures we need
        for (int i = 0; i < hairMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for Hair_#
            Texture2D temp = Resources.Load("Character/Hair_" + i) as Texture2D;
            hair.Add(temp);
            //add our temp texture that we just found to the hair List
        }
        //for loop looping from 0 to less than the max amount of mouth textures we need    
        for (int i = 0; i < mouthMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for Mouth_#
            Texture2D temp = Resources.Load("Character/Mouth_" + i) as Texture2D;
            mouth.Add(temp);

            //add our temp texture that we just found to the mouth List
        }
        //for loop looping from 0 to less than the max amount of eyes textures we need
        for (int i = 0; i < eyesMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for Eyes_#
            Texture2D temp = Resources.Load("Character/Eyes_" + i) as Texture2D;
            eyes.Add(temp);
            //add our temp texture that we just found to the eyes List
        }
        //for loop looping from 0 to less than the max amount of clothes textures we need
        for (int i = 0; i < clothesMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for Clothes_#
            Texture2D temp = Resources.Load("Character/Clothes_" + i) as Texture2D;
            clothes.Add(temp);
            //add our temp texture that we just found to the clothes List
        }
        //for loop looping from 0 to less than the max amount of armour textures we need
        for (int i = 0; i < armourMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for Armour_#
            Texture2D temp = Resources.Load("Character/Armour_" + i) as Texture2D;
            armour.Add(temp);
            //add our temp texture that we just found to the armour List
        }
        #endregion
        character = GameObject.Find("Mesh").GetComponent<SkinnedMeshRenderer>();
        SetTexture("Skin", 0);
        SetTexture("Hair", 0);
        SetTexture("Mouth", 0);
        SetTexture("Eyes", 0);
        SetTexture("Clothes", 0);
        SetTexture("Armour", 0);
    }

    #endregion

    //connect and find the SkinnedMeshRenderer thats in the scene to the variable we made for Renderer
    #region do this after making the function SetTexture
    #endregion
    #region SetTexture
    void SetTexture(string type, int dir)
    {
        //SetTexture skin, hair, mouth, eyes to the first texture 0
        int index = 0, max = 0, matIndex = 0;
        Texture2D[] textures = new Texture2D[0];
        //we need variables that exist only within this function
        //these are ints index numbers, max numbers, material index and Texture2D array of textures
        //inside a switch statement that is swapped by the string name of our material
        #region Switch Material
        switch (type)
        {
            //case skin
            case "Skin":
                index = skinIndex;
                //index is the same as our skin index
                max = skinMax;
                //max is the same as our skin max
                textures = skin.ToArray();
                //textures is our skin list .ToArray()
                matIndex = 1;
                //material index element number is 1
                break;
            //break
            case "Hair":
                index = hairIndex;
                //index is the same as our  index
                max = hairMax;
                //max is the same as our  max
                textures = hair.ToArray();
                //textures is our  list .ToArray()
                matIndex = 2;
                //material index element number is 2
                break;
            //break
            case "Mouth":
                index = mouthIndex;
                //index is the same as our  index
                max = mouthMax;
                //max is the same as our max
                textures = mouth.ToArray();
                //textures is our  list .ToArray()
                matIndex = 3;
                //material index element number is 3
                break;
            //break
            case "Eyes":
                index = eyesIndex;
                //index is the same as our  index
                max = eyesMax;
                //max is the same as our max
                textures = eyes.ToArray();
                //textures is our  list .ToArray()
                matIndex = 4;
                //material index element number is 4
                break;
            //break
            case "Clothes":
                index = clothesIndex;
                //index is the same as our  index
                max = clothesMax;
                //max is the same as our max
                textures = clothes.ToArray();
                //textures is our  list .ToArray()
                matIndex = 5;
                //material index element number is 5
                break;
            //break
            case "Armour":
                index = armourIndex;
                //index is the same as our  index
                max = armourMax;
                //max is the same as our max
                textures = armour.ToArray();
                //textures is our  list .ToArray()
                matIndex = 6;
                //material index element number is 6
                break;
                //break
        }

        #endregion
        #region OutSide Switch
        //outside our switch statement
        //index plus equals our direction
        index += dir;
        //cap our index to loop back around if is is below 0 or above max take one
        if (index < 0)
        {
            index = max - 1;
        }
        if (index > max - 1)
        {
            index = 0;
        }
        //Material array is equal to our characters material list
        Material[] mat = character.materials;

        //our material arrays current material index's main texture is equal to our texture arrays current index
        mat[matIndex].mainTexture = textures[index];

        //our characters materials are equal to the material array
        character.materials = mat;

        //create another switch that is goverened by the same string name of our material
        #endregion
        #region Set Material Switch
        switch (type)
        {
            case "Skin":
                skinIndex = index;
                break;
            case "Hair":
                hairIndex = index;
                break;
            case "Mouth":
                mouthIndex = index;
                break;
            case "Eyes":
                eyesIndex = index;
                break;
            case "Clothes":
                clothesIndex = index;
                break;
            case "Armour":
                armourIndex = index;
                break;
        }
        #endregion
    }
    #endregion

    #region Save
    //Function called Save this will allow us to save our indexes to PlayerPrefs
    void Save()
    {
        //SetInt for SkinIndex, HairIndex, MouthIndex, EyesIndex
        PlayerPrefs.SetInt("SkinIndex", skinIndex);
        PlayerPrefs.SetInt("HairIndex", hairIndex);
        PlayerPrefs.SetInt("MouthIndex", mouthIndex);
        PlayerPrefs.SetInt("EyesIndex", eyesIndex);
        PlayerPrefs.SetInt("ClothesIndex", clothesIndex);
        PlayerPrefs.SetInt("ArmourIndex", armourIndex);
        //SetString CharacterName
        PlayerPrefs.SetString("CharacterName", charName);
    }
    #endregion

    #region OnGUI
    //Function for our GUI elements
    private void OnGUI()
    {
        //create the floats scrW and scrH that govern our 16:9 ratio
        float scrW = Screen.width / 16;
        float scrH = Screen.height / 9;

        //create an int that will help with shuffling your GUI elements under eachother
        int i = 0;
        #region Skin
        //GUI button on the left of the screen with the contence <
        if (GUI.Button(new Rect(0.25f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "<"))
        {
            //when pressed the button will run SetTexture and grab the Skin Material and move the texture index in the direction  -1
            SetTexture("Skin", -1);
        }
        //GUI Box or Lable on the left of the screen with the contence Skin
        GUI.Box(new Rect(0.75f * scrW, scrH + i * (0.5f * scrH), 1f * scrW, 0.5f * scrH), "Skin");
        //GUI button on the left of the screen with the contence >
        if (GUI.Button(new Rect(1.75f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), ">"))
        {
            SetTexture("Skin", 1);
            //when pressed the button will run SetTexture and grab the Skin Material and move the texture index in the direction  1
        }
        i++;
        //move down the screen with the int using ++ each grouping of GUI elements are moved using this
        #endregion
        #region Hair
        //GUI button on the left of the screen with the contence <
        if (GUI.Button(new Rect(0.25f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "<"))
        {
            //when pressed the button will run SetTexture and grab the Hair Material and move the texture index in the direction  -1
            SetTexture("Hair", -1);
        }
        //GUI Box or Lable on the left of the screen with the contence Hair
        GUI.Box(new Rect(0.75f * scrW, scrH + i * (0.5f * scrH), 1f * scrW, 0.5f * scrH), "Hair");
        //GUI button on the left of the screen with the contence >
        if (GUI.Button(new Rect(1.75f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), ">"))
        {
            SetTexture("Hair", 1);
            //when pressed the button will run SetTexture and grab the Hair Material and move the texture index in the direction  1
        }
        i++;
        //move down the screen with the int using ++ each grouping of GUI elements are moved using this
        #endregion
        #region Mouth
        //GUI button on the left of the screen with the contence <
        if (GUI.Button(new Rect(0.25f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "<"))
        {
            //when pressed the button will run SetTexture and grab the Mouth Material and move the texture index in the direction  -1
            SetTexture("Mouth", -1);
        }
        //GUI Box or Lable on the left of the screen with the contence Mouth
        GUI.Box(new Rect(0.75f * scrW, scrH + i * (0.5f * scrH), 1f * scrW, 0.5f * scrH), "Mouth");
        //GUI button on the left of the screen with the contence >
        if (GUI.Button(new Rect(1.75f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), ">"))
        {
            SetTexture("Mouth", 1);
            //when pressed the button will run SetTexture and grab the Mouth Material and move the texture index in the direction  1
        }
        i++;
        //move down the screen with the int using ++ each grouping of GUI elements are moved using this
        #endregion
        #region Eyes
        //GUI button on the left of the screen with the contence <
        if (GUI.Button(new Rect(0.25f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "<"))
        {
            //when pressed the button will run SetTexture and grab the Eyes Material and move the texture index in the direction  -1
            SetTexture("Eyes", -1);
        }
        //GUI Box or Lable on the left of the screen with the contence Eyes
        GUI.Box(new Rect(0.75f * scrW, scrH + i * (0.5f * scrH), 1f * scrW, 0.5f * scrH), "Eyes");
        //GUI button on the left of the screen with the contence >
        if (GUI.Button(new Rect(1.75f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), ">"))
        {
            SetTexture("Eyes", 1);
            //when pressed the button will run SetTexture and grab the Eyes Material and move the texture index in the direction  1
        }
        i++;
        //move down the screen with the int using ++ each grouping of GUI elements are moved using this
        #endregion
        #region Clothes
        //GUI button on the left of the screen with the contence <
        if (GUI.Button(new Rect(0.25f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "<"))
        {
            //when pressed the button will run SetTexture and grab the Clothes Material and move the texture index in the direction  -1
            SetTexture("Clothes", -1);
        }
        //GUI Box or Lable on the left of the screen with the contence Clothes
        GUI.Box(new Rect(0.75f * scrW, scrH + i * (0.5f * scrH), 1f * scrW, 0.5f * scrH), "Clothes");
        //GUI button on the left of the screen with the contence >
        if (GUI.Button(new Rect(1.75f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), ">"))
        {
            SetTexture("Clothes", 1);
            //when pressed the button will run SetTexture and grab the Clothes Material and move the texture index in the direction  1
        }
        i++;
        //move down the screen with the int using ++ each grouping of GUI elements are moved using this
        #endregion
        #region Armour
        //GUI button on the left of the screen with the contence <
        if (GUI.Button(new Rect(0.25f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "<"))
        {
            //when pressed the button will run SetTexture and grab the Armour Material and move the texture index in the direction  -1
            SetTexture("Armour", -1);
        }
        //GUI Box or Lable on the left of the screen with the contence Armour
        GUI.Box(new Rect(0.75f * scrW, scrH + i * (0.5f * scrH), 1f * scrW, 0.5f * scrH), "Armour");
        //GUI button on the left of the screen with the contence >
        if (GUI.Button(new Rect(1.75f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), ">"))
        {
            SetTexture("Armour", 1);
            //when pressed the button will run SetTexture and grab the Armour Material and move the texture index in the direction  1
        }
        i++;
        //move down the screen with the int using ++ each grouping of GUI elements are moved using this
        #endregion
        #region Random Reset
        //create 2 buttons one Random and one Reset
        //Random will feed a random amount to the direction 
        //reset will set all to 0 both use SetTexture
        //move down the screen with the int using ++ each grouping of GUI elements are moved using this
        #endregion
        #region Character Name and Save & Play
        //name of our character equals a GUI TextField that holds our character name and limit of characters
        //move down the screen with the int using ++ each grouping of GUI elements are moved using this

        //GUI Button called Save and Play
        //this button will run the save function and also load into the game level
        #endregion
    }
    #endregion
    public enum CharacterClass
    {
        Barbarian,
        Bard,
        Druid,
        Monk,
        Paladin,
        Ranger,
        Sorcerer,
        Warlock
    }
}
