using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharactersPage : MonoBehaviour
{
    public Button[] tiles;
    public Sprite placeholderSprite;
    Notebook notebook;
    public GameObject bioPage;
    public Character[] characters;
    public Button bioExitButton;

    void OnValidate()
    {
    }
    void Start()
    {
        tiles[0].onClick.AddListener(() => populateButton(tiles[0], characters[0]));
        tiles[1].onClick.AddListener(() => populateButton(tiles[1], characters[1]));
        tiles[2].onClick.AddListener(() => populateButton(tiles[2], characters[2]));
        tiles[3].onClick.AddListener(() => populateButton(tiles[3], characters[3]));
        tiles[4].onClick.AddListener(() => populateButton(tiles[4], characters[4]));
        tiles[5].onClick.AddListener(() => populateButton(tiles[5], characters[5]));
    }

    /// <summary>
    /// opens the bio page and populates it with the given character taken from the index given.
    /// </summary>
    /// <param name="index"></param>
    public void goToBio(Character _character)
    {
        print($"clicked button: {_character}");
        // TODO: check wether the character is met. If not, pop up says: you have not met this person yet.
    }

    /// <summary>
    /// populate a button in the characters page with the given character
    /// </summary>
    /// <param name="character"></param>
    public void populateButton(Button button, Character character)
    {
        button.transform.GetChild(0).GetComponent<Image>().sprite = character.photo;
        button.GetComponentInChildren<Text>().text = character.nickName;
        print($"populated button: {button} with character {character}");
        button.GetComponent<CharacterTile>().onPopulate();
    }
}