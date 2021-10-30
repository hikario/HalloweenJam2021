using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMethods : MonoBehaviour
{
    public GameObject poemPiece;
    private CanvasGroup canvasGroup;

    public GameObject collectible;

    public SpriteRenderer giftRenderer;

    public void ItemClick()
    {
        if (poemPiece.activeSelf == false)
        {
            poemPiece.SetActive(true);
            canvasGroup = gameObject.GetComponentInParent<CanvasGroup>();
            canvasGroup.interactable = false;
        }
    }

    public void PageClick()
    {

    }

    public void OpenPackage(string buttonName)
    {
        collectible.SetActive(true);
        gameObject.SetActive(false);
    }
}
