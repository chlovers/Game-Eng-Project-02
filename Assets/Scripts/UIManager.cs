using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject mainmenu;
    public GameObject pausemenu;
    public GameObject gameplayUI;
    public GameObject optionsui;

    public Image image;
    public Slider slider;

    public void EnableMainMenu()
    {
        TurnoffAll();
        mainmenu.SetActive(true);

    }

    public void EnablePause()
    {
        TurnoffAll();
        pausemenu.SetActive(true);

    }

    public void EnableOptions()
    {
        
    TurnoffAll();
    optionsui.SetActive(true);
    
    }

    public void GamePlayUI()
    {
        TurnoffAll();
        gameplayUI.SetActive(true);
    }

    public void TurnoffAll()
    {
        mainmenu.SetActive(false);
        pausemenu.SetActive(false);
        gameplayUI.SetActive(false);
        optionsui.SetActive(false);
    }

    private void Start()
    {
       image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        slider.value = 0f;
        slider.onValueChanged.AddListener(sliderchange);
    }

    public void sliderchange(float Slider)
    {
        Color currentcolor = image.color;
        image.color = new Color(currentcolor.r, currentcolor.g, currentcolor.b, Slider);

    }

}
