using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button ButtonOne;
    public Button ButtonTwo;
    public Button ButtonThree;
    public Button ButtonFour;
    public Button ButtonFive;
    public Button ButtonSix;
    public Button ButtonSeven;
    public Button ButtonEight;
    public Button ButtonNine;

    private void Start()
    {
        ButtonOne.onClick.AddListener(() =>
        {
            SetButtonInteractable(false);
            SceneManager.LoadScene(1);
        });
        ButtonTwo.onClick.AddListener(() =>
        {
            SetButtonInteractable(false);
            SceneManager.LoadScene(2);
        });
        ButtonThree.onClick.AddListener(() =>
        {
            SetButtonInteractable(false);
            SceneManager.LoadScene(3);
        });
        ButtonFour.onClick.AddListener(() =>
        {
            SetButtonInteractable(false);
            SceneManager.LoadScene(4);
        });
        ButtonFive.onClick.AddListener(() =>
        {
            SetButtonInteractable(false);
            SceneManager.LoadScene(5);
        });
        ButtonSix.onClick.AddListener(() =>
        {
            SetButtonInteractable(false);
            SceneManager.LoadScene(6);
        });
        ButtonSeven.onClick.AddListener(() =>
        {
            SetButtonInteractable(false);
            SceneManager.LoadScene(7);
        });
        ButtonEight.onClick.AddListener(() =>
        {
            SetButtonInteractable(false);
            SceneManager.LoadScene(8);
        });
        ButtonNine.onClick.AddListener(() =>
        {
            SetButtonInteractable(false);
            SceneManager.LoadScene(9);
        });
    }

    private void SetButtonInteractable(bool interactable)
    {
        ButtonOne.interactable = interactable;
        ButtonTwo.interactable = interactable;
        ButtonThree.interactable = interactable;
        ButtonFour.interactable = interactable;
        ButtonFive.interactable = interactable;
        ButtonSix.interactable = interactable;
        ButtonSeven.interactable = interactable;
        ButtonEight.interactable = interactable;
        ButtonNine.interactable = interactable;
    }
}
