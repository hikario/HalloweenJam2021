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

    public int currentScene;
    public int totalScenes;

    public void ItemClick()
    {
        if (poemPiece.activeSelf == false)
        {
            poemPiece.SetActive(true);
            canvasGroup = gameObject.GetComponentInParent<CanvasGroup>();
            canvasGroup.interactable = false;
        }
    }

    public void NoteClick()
    {
        if (poemPiece.activeSelf == true)
        {
            poemPiece.SetActive(false);
            canvasGroup = gameObject.GetComponentInParent<CanvasGroup>();
            canvasGroup.interactable = true;
        }
    }

    public void TurnPage()
    {
        currentScene++;
        Fungus.Flowchart.BroadcastFungusMessage("Start Scene " + currentScene);

        if (currentScene >= 7)
        {
            currentScene = 0;
        }
    }
}
