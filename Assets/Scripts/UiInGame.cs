using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiInGame : MonoBehaviour
{
    public GameObject OptionsMenu;
    public GameObject InGameMenu;
    public GameObject DiscontMenu;
    public GameObject Map;
    public GameObject Paintings;
    public GameObject[] Italian;
    public GameObject[] English;
    public GameObject[] FirstPainting;
    public GameObject[] SecondPainting;
    public GameObject[] ThirdPainting;
    public GameObject[] FourthPainting;
    public GameObject[] FifthPainting;
    public GameObject[] SixthPainting;
    public Text[] Completed;
    public Text[] LanguageTexts;
    // Start is called before the first frame update
    void Start()
    {
        Completed[0].text = PersistantObject.CompletedMinigames.ToString() + "/3";
        Completed[1].text = PersistantObject.CompletedMinigames.ToString() + "/3";
        CheckCompletedMinigames();
        CheckLanguage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckLanguage()
    {
        if(PersistantObject.MaintainLanguage==0)
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
            LanguageTexts[0].text = "Rewards";
            LanguageTexts[1].text = "Complete the minigames \n to unlock the rest of the code";
            LanguageTexts[2].text = "Resume";
            LanguageTexts[3].text = "Paintings";
            LanguageTexts[4].text = "Discount";
            LanguageTexts[5].text = "Main Menu";
        }
        else if(PersistantObject.MaintainLanguage==1)
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
            LanguageTexts[0].text = "Ricompense";
            LanguageTexts[1].text = "Completa i minigiochi \n per sbloccare il resto del codice";
            LanguageTexts[2].text = "Ricomincia";
            LanguageTexts[3].text = "Quadri";
            LanguageTexts[4].text = "Sconto";
            LanguageTexts[5].text = "Menu Principale";
        }
    }

    #region Navigation buttons
    public void OpenOption()
    {
        InGameMenu.SetActive(false);
        OptionsMenu.SetActive(true);
    }
    public void CloseOptions()
    {
        InGameMenu.SetActive(true);
        OptionsMenu.SetActive(false);
    }
    public void OpenDiscount()
    {
        OptionsMenu.SetActive(false);
        InGameMenu.SetActive(false);
        DiscontMenu.SetActive(true);
    }
    public void CloseDiscount()
    {
        InGameMenu.SetActive(true);
        DiscontMenu.SetActive(false);
    }
    public void OpenMap()
    {
        InGameMenu.SetActive(false);
        Map.SetActive(true);
    }
    public void CloseMap()
    {
        InGameMenu.SetActive(true);
        Map.SetActive(false);
    }
    public void OpenPaintings()
    {
        OptionsMenu.SetActive(false);
        Paintings.SetActive(true);
    }
    public void ClosePaintings()
    {
        OptionsMenu.SetActive(true);
        Paintings.SetActive(false);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
    #endregion

    public void CheckCompletedMinigames()
    {
        if (PersistantObject.Intruder == 1)
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
        if (PersistantObject.Differences == 1)
        {
            SecondPainting[0].SetActive(true);
            SecondPainting[1].SetActive(false);
        }
        else
        {
            SecondPainting[0].SetActive(false);
            SecondPainting[1].SetActive(true);
        }
        if (PersistantObject.Fifteen == 1)
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

    #region Paintings
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
