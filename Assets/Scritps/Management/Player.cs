using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Player : MonoBehaviour {

    public static Player instance = null;
    public Monsters player;
    public Text hp;
    public string playerCard;

    void Awake () {
        if (instance == null) {
            instance = this;
        }
        CheckingSelectedCharacter ();
        print ("player: " + player.nameMonster + " and THE HP IS: " + player.hp);

    }

    void Update () {
        hp.text = player.hp.ToString();
    }

    public void CheckingSelectedCharacter () {
        switch (PlayerPrefs.GetString ("type")) {
            case "Alien":
                player = new Alien ();
            break;

            case "Robot":
                player = new Robot ();
            break;

            case "Beast":
                player = new Beast ();
            break;

            case "Mutant":
                player = new Mutant ();
            break;

            case "Elemental":
                player = new Elemental ();
            break;

            case "Mystic":
                player = new Mystic ();
            break;

            case "Random":
                RandomType ();
            break;
        }
        
    }

    public void RandomType () {
        switch (Random.Range (0, 6)) {
            case 0:
            PlayerPrefs.SetString ("type", "Alien");
            break;

            case 1:
            PlayerPrefs.SetString ("type", "Robot");
            break;

            case 2:
            PlayerPrefs.SetString ("type", "Beast");
            break;

            case 3:
            PlayerPrefs.SetString ("type", "Mutant");
            break;

            case 4:
            PlayerPrefs.SetString ("type", "Elemental");
            break;

            case 5:
            PlayerPrefs.SetString ("type", "Mystic");
            break;

        }
    }
}
