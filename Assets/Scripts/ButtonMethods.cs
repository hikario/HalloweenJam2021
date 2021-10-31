using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Fungus;

public class ButtonMethods : MonoBehaviour
{
    public Button item;
    public GameObject poemPiece;
    private CanvasGroup canvasGroup;

    public int currentScene = 1;
    public int totalScenes;

    public void Start()
    {
        currentScene = 1;
    }

    public void ItemClick()
    {
        if (poemPiece.activeSelf == false)
        {
            poemPiece.SetActive(true);
            canvasGroup = gameObject.GetComponentInParent<CanvasGroup>();
            canvasGroup.interactable = false;
        }
    }

    public void JournalClick()
    {
        Debug.Log("Read Journal " + currentScene);
        Fungus.Flowchart.BroadcastFungusMessage("Read Journal " + currentScene);

    }

    public void TurnPage()
    {
        currentScene++;
        Debug.Log("Current Scene is " + currentScene);
        Fungus.Flowchart.BroadcastFungusMessage("Start Scene " + currentScene);

        if (currentScene >= 7)
        {
            currentScene = 0;
        }
    }
}
