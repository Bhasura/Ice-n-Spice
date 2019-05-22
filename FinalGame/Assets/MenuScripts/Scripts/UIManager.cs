using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class UIManager : MonoBehaviour
{
    public RectTransform mainMenu, stage1, stage2, loadingScreen, shopPanel;
    public GameObject optionsPanel;
    public GameObject S2Locked;
    public Player p;
   
    
    public Text tutorialCompletion;
    public Text S2Completion;
    // Start is called before the first frame update
    void Start()
    {
        mainMenu.DOAnchorPos(Vector2.zero, 0.25f);
        stage2Completion();
        p.LoadPlayer();

    }

    // Update is called once per frame
    //in main menu
    public void resetGame()
    {
        p = new Player();
        p.stageCompletion[0] = 0;
        p.stageCompletion[1] = 0;

        p.SavePlayerData();
        
    }
    public void stage1Completion()
    {
        print(p.stageCompletion[0]);
        tutorialCompletion.text = p.stageCompletion[0].ToString();
        if (p.stageCompletion[0] == 100)
        {
            print("s2 unlocked");
            S2Locked.SetActive(false);
        }
        else
        {
            S2Locked.SetActive(true);
        }
    }
    public void stage2Completion()
    {
        S2Completion.text = p.stageCompletion[1].ToString();
    }
    public void goToStage1()
    {
        mainMenu.DOAnchorPos(new Vector2(0, -529), 0.25f);
        stage1.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    public void showOptionsPanel()
    {
        optionsPanel.SetActive(true);
    }
    public void hideOptionsPanel()
    {
        optionsPanel.SetActive(false);
    }
   
    public void goShop()
    {
        mainMenu.DOAnchorPos(new Vector2(0, -529), 0.25f);
        shopPanel.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    //in shop
    public void goMenushop()
    {
        shopPanel.DOAnchorPos(new Vector2(-1080, -540), 0.25f);
        mainMenu.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    //in stage 1
    public void goToStage2()
    {
        stage1.DOAnchorPos(new Vector2(-1080, 0), 0.25f);
        stage2.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void s1MainMenu()
    {
        stage1.DOAnchorPos(new Vector2(-1080, 0), 0.25f);
        mainMenu.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void s1Start()
    {
        stage1.DOAnchorPos(new Vector2(-1080, 0), 0.25f);
        loadingScreen.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    //in stage 2
    public void s2LockedButton()
    {
        if(TestCollision.complete[0] == 100)
        {
            S2Locked.SetActive(false);
        }
    }
    public void s2GoToStage1()
    {
        stage2.DOAnchorPos(new Vector2(1100, 0), 0.25f);
        stage1.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void s2MainMenu()
    {
        stage2.DOAnchorPos(new Vector2(1100, 0), 0.25f);
        mainMenu.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    public void s2Start()
    {
       
        stage2.DOAnchorPos(new Vector2(1100, 0), 0.25f);
        loadingScreen.DOAnchorPos(new Vector2(0, 0), 0.25f);
        
       
        
    }

}
