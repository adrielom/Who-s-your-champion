using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Oponent : MonoBehaviour {

    public static Oponent instance = null;
    public Monsters oponent;
    Cards[] cardsOponent = new Cards[5];
    public Text hp;

    void Awake () {
        if (instance == null) {
            instance = this;
        }
        RandomType ();
        CheckingSelectedCharacter ();
        print ("Oponent: " + oponent.nameMonster);
        print (oponent.hp);

    }

    void Update () {
        hp.text = oponent.hp.ToString ();
    }

    public void CheckingSelectedCharacter () {
        switch (PlayerPrefs.GetString ("typeO")) {
            case "Alien":
            oponent = new Alien ();
            break;

            case "Robot":
            oponent = new Robot ();
            break;

            case "Beast":
            oponent = new Beast ();
            break;

            case "Mutant":
            oponent = new Mutant ();
            break;

            case "Elemental":
            oponent = new Elemental ();
            break;

            case "Mystic":
            oponent = new Mystic ();
            break;

        }

    }

    public void RandomType () {
        switch (Random.Range (0, 6)) {
            case 0:
                PlayerPrefs.SetString ("typeO", "Alien");
            break;

            case 1:
                PlayerPrefs.SetString ("typeO", "Robot");
            break;

            case 2:
                PlayerPrefs.SetString ("typeO", "Beast");
            break;

            case 3:
                PlayerPrefs.SetString ("typeO", "Mutant");
            break;

            case 4:
                PlayerPrefs.SetString ("typeO", "Elemental");
            break;

            case 5:
                PlayerPrefs.SetString ("typeO", "Mystic");
            break;

        }
    }
}
