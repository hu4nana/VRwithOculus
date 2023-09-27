using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patterns : MonoBehaviour
{
    // 왼쪽과 오른쪽 미트 오브젝트
    public GameObject LM;
    public GameObject RM;

    
    int curCombo;
    int maxCombo;

    public int GetcurCombo() { return curCombo; }
    public void SetcurCombo(int value) { curCombo = value;}
    public int GetmaxCombo() { return maxCombo;}
    public void SetmaxCombo(int value) { maxCombo = value;}



    // 패턴 데이터
    public void PatternData(int value)
    {
        switch (value)
        {
            case 0:
                maxCombo = 2;
                switch (curCombo)
                {
                    case 0:
                        PatternJap();
                        break;
                    case 1:
                        PatternStraight();
                        break;
                }
                break;
            case 1:
                maxCombo = 4;
                switch (curCombo)
                {
                    case 0:
                        PatternJap();
                        break;
                    case 1:
                        PatternStraight();
                        break;
                    case 2:
                        PatternJap();
                        break;
                    case 3:
                        PatternStraight();
                        break;
                }
                break;
            case 2:
                maxCombo = 3;
                switch (curCombo)
                {
                    case 0:
                        PatternStraight();
                        break;
                    case 1:
                        PatternJap();
                        break;
                    case 2:
                        PatternStraight();
                        break;
                }
                break;
            case 3:
                maxCombo = 3;
                switch (curCombo)
                {
                    case 0:
                        PatternJap();
                        break;
                    case 1:
                        PatternJap();
                        break;
                    case 2:
                        PatternStraight();
                        break;
                }
                break;
            case 4:
                maxCombo = 3;
                switch (curCombo)
                {
                    case 0:
                        PatternJap();
                        break;
                    case 1:
                        PatternStraight();
                        break;
                    case 2:
                        PatternLeadHook();
                        break;
                }
                break;
            case 5:
                maxCombo = 4;
                switch (curCombo)
                {
                    case 0:
                        PatternJap();
                        break;
                    case 1:
                        PatternStraight();
                        break;
                    case 2:
                        PatternLeadHook();
                        break;
                    case 3:
                        PatternLearHook();
                        break;
                }
                break;
            case 6:
                maxCombo = 3;
                switch (curCombo)
                {
                    case 0:
                        PatternJap();
                        break;
                    case 1:
                        PatternStraight();
                        break;
                    case 2:
                        PatternLeadUpper();
                        break;
                }
                break;
            case 7:
                maxCombo = 4;
                switch (curCombo)
                {
                    case 0:
                        PatternJap();
                        break;
                    case 1:
                        PatternStraight();
                        break;
                    case 2:
                        PatternBothHook();
                        break;
                    case 3:
                        PatternBothUpper();
                        break;
                }
                break;
        }
    }

    //=========================해당 액션의 미트 위치 작성================
    public void PatternJap()
    {
        Debug.Log("Jap");
    }
    public void PatternStraight()
    {
        Debug.Log("Straight");
    }
    public void PatternLeadHook()
    {
        Debug.Log("LeadHook");
    }
    public void PatternLearHook()
    {
        Debug.Log("LearHook");
    }
    public void PatternLeadUpper()
    {
        Debug.Log("LeadUpper");
    }
    public void PatternBothHook()
    {
        Debug.Log("BothHook");
    }
    public void PatternBothUpper()
    {
        Debug.Log("BothUpper");
    }
    public void PatternDodge()
    {
        Debug.Log("Dodge");
    }
}
