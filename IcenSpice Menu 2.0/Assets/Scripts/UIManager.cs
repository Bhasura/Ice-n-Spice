using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class UIManager : MonoBehaviour
{
    public RectTransform mainMenu, stage1, stage2, loadingScreen;
    public GameObject optionsPanel;
    public GameObject S2Locked;
    Player p = new Player();
   
    
    public Text tutorialCompletion;
    public Text S2Completion;
    // Start is called before the first frame update
    void Start()
    {
        mainMenu.DOAnchorPos(Vector2.zero, 0.25f);
        stage2Completion();
        if (TestCollision.complete[0] == 100)
        {
            S2Locked.SetActive(false);
        }

    }

    // Update is called once per frame
    //in main menu
    public void stage1Completion()
    {

        tutorialCompletion.text = TestCollision.complete[0].ToString();
        
    }
    public void stage2Completion()
    {
        S2Completion.text = TestCollision.complete[1].ToString();
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
