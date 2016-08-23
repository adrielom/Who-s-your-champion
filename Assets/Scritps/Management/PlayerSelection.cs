using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerSelection : MonoBehaviour {

    public void SettingPlayerClass () {

        switch (gameObject.GetComponent<Button> ().name) {
            case "Alien":
                PlayerPrefs.SetString ("type", "Alien");
            break;

            case "Robot":
                PlayerPrefs.SetString ("type", "Robot");
            break;

            case "Beast":
                PlayerPrefs.SetString ("type", "Beast");
            break;

            case "Mutant":
                PlayerPrefs.SetString ("type", "Mutant");
            break;

            case "Elemental":
                PlayerPrefs.SetString ("type", "Elemental");
            break;

            case "Mystic":
                PlayerPrefs.SetString ("type", "Mystic");
            break;
        }

        SceneManager.LoadScene ("Jogo");

    }

}
