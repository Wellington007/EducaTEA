using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScreenMenu : MonoBehaviour {

    public Button buttonEasy;
    public Button buttonNormal;
    public Button buttonHard;
    public Button buttonChangeLanguage;

    public void Start() {
        string lang = PlayerPrefs.GetString("lang");
        if (lang == null) {
            lang = "fr";
            PlayerPrefs.SetString("lang", lang);
        }

<<<<<<< HEAD
        buttonEasy.gameObject.transform.GetChild(0).GetComponent<Text>().text = (lang == "fr" ? "Débutant" : "Fácil");
        buttonNormal.gameObject.transform.GetChild(0).GetComponent<Text>().text = (lang == "fr" ? "Apprenti" : "Normal");
        buttonHard.gameObject.transform.GetChild(0).GetComponent<Text>().text = (lang == "fr" ? "Champion" : "Difícil");
=======
        buttonEasy.gameObject.transform.GetChild(0).GetComponent<Text>().text = (lang == "fr" ? "Débutant" : "Easy");
        buttonNormal.gameObject.transform.GetChild(0).GetComponent<Text>().text = (lang == "fr" ? "Apprenti" : "Normal");
        buttonHard.gameObject.transform.GetChild(0).GetComponent<Text>().text = (lang == "fr" ? "Champion" : "Hard");
>>>>>>> 5a6637c3cec9b40273510db1b8cc7f4b33fbbab3
        buttonChangeLanguage.gameObject.transform.GetChild(0).GetComponent<Text>().text = (lang == "fr" ? "English" : "Français");
    }


    public void Show() {
        gameObject.SetActive(true);
    }

}
