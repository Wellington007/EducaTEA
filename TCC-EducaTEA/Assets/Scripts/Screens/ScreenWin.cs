using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScreenWin : MonoBehaviour {

    public GameObject[] stars;

    public Text textTitle;
<<<<<<< HEAD:Assets/Scripts/Screens/ScreenWin.cs

=======


    public void Show(int errors) {
        textTitle.text = (PlayerPrefs.GetString("lang") == "fr" ? "Bravo!" : "Wonderful!");
>>>>>>> 5a6637c3cec9b40273510db1b8cc7f4b33fbbab3:Assets/Scripts/Screens/ScreenWin.cs

    public void Show(int errors) {
        textTitle.text = (PlayerPrefs.GetString("lang") == "fr" ? "Bravo!" : "Parabéns!\n" + "Você acertou!");
        
        // Remove all previous stars
        for (int i=0; i<stars.Length; i++) {
            stars[i].SetActive(false);
        }
        // Show all stars depending on the number of tries
        for (int i=0; i<stars.Length - errors; i++) {
            stars[i].SetActive(true);
        }
        // Show the Win popup
        gameObject.SetActive(true);
        SoundEngine.instance.PlaySound(SoundEngine.instance.audioWin);
    }


    public void Close() {
        gameObject.SetActive(false);
    }


}
