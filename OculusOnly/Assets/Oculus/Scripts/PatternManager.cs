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
    // isDodge�� 1�� �� PatternDodge()����
    int isDodge = 0;

    
    bool isEnd = false;
    Patterns Patterns = new Patterns();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PatternSelecter();
    }

    // � ������ �ҷ����� ����
    public void PatternSelecter()
    {
        if (isEnd)
        {
            curPattern = Random.Range(0, 8);
            isDodge = Random.Range(0, 2);
            patternTime = 3;
            isEnd = false;
            Debug.Log("Current Pattern is" + curPattern);
            Debug.Log("isDodge is" + isDodge);

        }
        else
        {
            PatternController();
        }

    }

    // ���� �������� ������ �޾ƿ� �����Ŵ
    public void PatternController()
    {
        if (!isEnd)
        {
            patternTimer += Time.deltaTime;
            if (patternTimer >= patternTime)
            {
                Patterns.PatternData(curPattern);
                if (Patterns.GetcurCombo() < Patterns.GetmaxCombo())
                {
                    patternTimer = 0;
                    Patterns.SetcurCombo(++curCombo);
                    //Debug.Log("Current Combo is " + curCombo);
                    //Debug.Log("GetCurrentCombo is " + Patterns.GetcurCombo());
                    
                }
                else
                {
                    //Debug.Log("Current Combo " + curCombo
                    //    + "maxCombo is " + Patterns.GetmaxCombo());
                    //Debug.Log("The End of the Combo");
                    patternTimer = 0;
                    Patterns.SetcurCombo(curCombo = 0);
                    if (isDodge == 1)
                    {
                        Patterns.PatternDodge();
                    }
                    isEnd = true;
                    //if (patternTimer >= patternTime * 3)
                    //{
                    //    patternTimer = 0;
                    //    Patterns.SetcurCombo(curCombo = 0);
                    //    isEnd = true;
                    //}
                }
            }
        }
        
    }
}
