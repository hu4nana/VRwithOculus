using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternManager : MonoBehaviour
{
    int maxPattern;
    int curPattern;


    int curCombo=0;
    float patternTimer;
    float patternTime;
    // isDodge가 1일 때 PatternDodge()실행
    int isDodge = 0;

    
    bool isEnd = false;
    Patterns Patterns = new Patterns();

    public GameObject rm;
    public GameObject lm;

    Mitt_Right mr;
    Mitt_Left ml;
    //MeetObject mObj=new MeetObject();

    private void Awake()
    {
        mr=rm.GetComponent<Mitt_Right>();
        ml=lm.GetComponent<Mitt_Left>();
    }
    // Update is called once per frame
    void Update()
    {
        PatternSelecter();
    }

    // 어떤 패턴을 불러올지 정함
    public void PatternSelecter()
    {
        if (isEnd)
        {
            curPattern = Random.Range(0, 8);
            isDodge = Random.Range(0, 2);
            patternTime = 3f;
            
            isEnd = false;
            //Debug.Log("Current Pattern is" + curPattern);
            //Debug.Log("isDodge is" + isDodge);
        }
        else
        {
            PatternController();
        }

    }

    // 패턴 데이터의 내용을 받아와 실행시킴
    public void PatternController()
    {
        if (!isEnd)
        {
            patternTimer += Time.deltaTime;
            if ((mr.GetCollision() || ml.GetCollision())|| (patternTimer >= patternTime))
            {
                Patterns.PatternData(curPattern);
                if (Patterns.GetcurCombo() < Patterns.GetmaxCombo())
                {
                    patternTimer = 0;
                    Patterns.SetcurCombo(++curCombo);
                    Debug.Log("Current Combo is " + curCombo);
                    Debug.Log("GetCurrentCombo is " + Patterns.GetcurCombo());
                    
                }
                else
                {
                    //Debug.Log("Current Combo " + curCombo
                    //    + "maxCombo is " + Patterns.GetmaxCombo());
                    //Debug.Log("The End of the Combo");

                    //if (patternTimer >= patternTime * 3)
                    //{
                    //    patternTimer = 0;
                    //    Patterns.SetcurCombo(curCombo = 0);
                    //    isEnd = true;
                    //}
                    patternTimer = 0;
                    Patterns.SetcurCombo(curCombo = 0);
                    if (isDodge == 1)
                    {
                        Patterns.PatternDodge();
                    }
                    isEnd = true;
                    Patterns.InitPos();
                }
            }
        }
        
    }
}
