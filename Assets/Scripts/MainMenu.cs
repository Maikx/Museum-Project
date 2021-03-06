﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public bool Language;
    public GameObject[] Italian;
    public GameObject[] English;
    public GameObject[] FirstPainting;
    public GameObject[] SecondPainting;
    public GameObject[] ThirdPainting;
    public GameObject[] FourthPainting;
    public GameObject[] FifthPainting;
    public GameObject[] SixthPainting;
    public GameObject mainMenu;
    public GameObject Paintings;
    public GameObject Rewards;
    // Start is called before the first frame update
    void Start()
    {
        if(PersistantObject.MaintainLanguage==0)
        {
            Language = false;
        }
        else if(PersistantObject.MaintainLanguage==1)
        {
            Language = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        CheckLanguage();
        CheckCompletedMinigames();
    }

    public void CheckLanguage()
    {
        if(Language==false)
        {
            English[0].SetActive(true);
            English[1].SetActive(true);
            English[2].SetActive(true);
            English[3].SetActive(true);
            English[4].SetActive(true);
            English[5].SetActive(true);
            English[6].SetActive(true);
            English[7].SetActive(true);
            English[8].SetActive(true);
            English[9].SetActive(true);
            English[10].SetActive(true);
            English[11].SetActive(true);
            English[12].SetActive(true);
            English[13].SetActive(true);
            English[14].SetActive(true);
            English[15].SetActive(true);
            English[16].SetActive(true);
            English[17].SetActive(true);
            English[18].SetActive(true);
            English[19].SetActive(true);
            Italian[0].SetActive(false);
            Italian[1].SetActive(false);
            Italian[2].SetActive(false);
            Italian[3].SetActive(false);
            Italian[4].SetActive(false);
            Italian[5].SetActive(false);
            Italian[6].SetActive(false);
            Italian[7].SetActive(false);
            Italian[8].SetActive(false);
            Italian[9].SetActive(false);
            Italian[10].SetActive(false);
            Italian[11].SetActive(false);
            Italian[12].SetActive(false);
            Italian[13].SetActive(false);
            Italian[14].SetActive(false);
            Italian[15].SetActive(false);
            Italian[16].SetActive(false);
            Italian[17].SetActive(false);
            Italian[18].SetActive(false);
            Italian[19].SetActive(false);
        }
        else
        {
            English[0].SetActive(false);
            English[1].SetActive(false);
            English[2].SetActive(false);
            English[3].SetActive(false);
            English[4].SetActive(false);
            English[5].SetActive(false);
            English[6].SetActive(false);
            English[7].SetActive(false);
            English[8].SetActive(false);
            English[9].SetActive(false);
            English[10].SetActive(false);
            English[11].SetActive(false);
            English[12].SetActive(false);
            English[13].SetActive(false);
            English[14].SetActive(false);
            English[15].SetActive(false);
            English[16].SetActive(false);
            English[17].SetActive(false);
            English[18].SetActive(false);
            English[19].SetActive(false);
            Italian[0].SetActive(true);
            Italian[1].SetActive(true);
            Italian[2].SetActive(true);
            Italian[3].SetActive(true);
            Italian[4].SetActive(true);
            Italian[5].SetActive(true);
            Italian[6].SetActive(true);
            Italian[7].SetActive(true);
            Italian[8].SetActive(true);
            Italian[9].SetActive(true);
            Italian[10].SetActive(true);
            Italian[11].SetActive(true);
            Italian[12].SetActive(true);
            Italian[13].SetActive(true);
            Italian[14].SetActive(true);
            Italian[15].SetActive(true);
            Italian[16].SetActive(true);
            Italian[17].SetActive(true);
            Italian[18].SetActive(true);
            Italian[19].SetActive(true);
        }
    }

    public void CheckCompletedMinigames()
    {
        if(PersistantObject.Intruder==1)
        {
            ThirdPainting[0].SetActive(true);
            ThirdPainting[1].SetActive(false);
            FourthPainting[0].SetActive(true);
            FourthPainting[1].SetActive(false);
            FifthPainting[0].SetActive(true);
            FifthPainting[1].SetActive(false);
            SixthPainting[0].SetActive(true);
            SixthPainting[1].SetActive(false);
        }
        else
        {
            ThirdPainting[0].SetActive(false);
            ThirdPainting[1].SetActive(true);
            FourthPainting[0].SetActive(false);
            FourthPainting[1].SetActive(true);
            FifthPainting[0].SetActive(false);
            FifthPainting[1].SetActive(true);
            SixthPainting[0].SetActive(false);
            SixthPainting[1].SetActive(true);

        }
        if(PersistantObject.Differences==1)
        {
            SecondPainting[0].SetActive(true);
            SecondPainting[1].SetActive(false);
        }
        else
        {
            SecondPainting[0].SetActive(false);
            SecondPainting[1].SetActive(true);
        }
        if(PersistantObject.Fifteen==1)
        {
            FirstPainting[0].SetActive(true);
            FirstPainting[1].SetActive(false);
        }
        else
        {
            FirstPainting[0].SetActive(false);
            FirstPainting[1].SetActive(true);
        }
    }

    #region Set language
    public void SetEnglish()
    {
        Language = false;
        PersistantObject.MaintainLanguage = 0;
        PlayerPrefs.SetInt("Language", 0);
    }
    public void SetItalian()
    {
        Language = true;
        PersistantObject.MaintainLanguage = 1;
        PlayerPrefs.SetInt("Language", 1);
    }
    #endregion

    #region Buttons
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void GoToPaintings()
    {
        mainMenu.SetActive(false);
        Paintings.SetActive(true);
    }
    public void GoToRewards()
    {
        mainMenu.SetActive(false);
        Rewards.SetActive(true);
    }
    public void BackToMenu()
    {
        Paintings.SetActive(false);
        Rewards.SetActive(false);
        mainMenu.SetActive(true);
    }
    public void firstPainting()
    {
        FirstPainting[2].SetActive(true);
    }
    public void secondPainting()
    {
        SecondPainting[2].SetActive(true);
    }
    public void thirdPainting()
    {
        ThirdPainting[2].SetActive(true);
    }
    public void fourthPainting()
    {
        FourthPainting[2].SetActive(true);
    }
    public void fifthPainting()
    {
        FifthPainting[2].SetActive(true);
    }
    public void sixthPainting()
    {
        SixthPainting[2].SetActive(true);
    }
    public void OpenFirstPainting()
    {
        FirstPainting[3].SetActive(true);
    }
    public void CloseFirstPainting()
    {
        FirstPainting[3].SetActive(false);
    }
    public void OpenSecondPainting()
    {
        SecondPainting[3].SetActive(true);
    }
    public void CloseSecondPainting()
    {
        SecondPainting[3].SetActive(false);
    }
    public void OpenThirdPainting()
    {
        ThirdPainting[3].SetActive(true);
    }
    public void CloseThirdPainting()
    {
        ThirdPainting[3].SetActive(false);
    }
    public void OpenFourthPainting()
    {
        FourthPainting[3].SetActive(true);
    }
    public void CloseFourthPainting()
    {
        FourthPainting[3].SetActive(false);
    }
    public void OpenFifthPainting()
    {
        FifthPainting[3].SetActive(true);
    }
    public void CloseFifthPainting()
    {
        FifthPainting[3].SetActive(false);
    }
    public void OpenSixthPainting()
    {
        SixthPainting[3].SetActive(true);
    }
    public void CloseSixthPainting()
    {
        SixthPainting[3].SetActive(false);
    }
    public void BackToPaintings()
    {
        FirstPainting[2].SetActive(false);
        SecondPainting[2].SetActive(false);
        ThirdPainting[2].SetActive(false);
        FourthPainting[2].SetActive(false);
        FifthPainting[2].SetActive(false);
        SixthPainting[2].SetActive(false);
    }
    #endregion
}
