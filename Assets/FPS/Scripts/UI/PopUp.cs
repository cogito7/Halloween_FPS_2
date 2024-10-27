using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopUp : MonoBehaviour
{
    public TMP_Text popupText;

    private GameObject window;
    private GameObject popupAnimator;
    private Queue<string> popupQueue;
    private bool isActive;
    private Coroutine queueChecker;

    private void ShowPopup(string text)
    {
        isActive = true;
        window.SetActive(true);
        popupText.text = text;

    }


}
