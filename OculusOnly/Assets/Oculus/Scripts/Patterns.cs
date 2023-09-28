using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Patterns : MonoBehaviour
{
    public Text TxtCombo;

    public Transform[] AttackPos = new Transform[5];
    public GameObject LM;
    public GameObject RM;


    bool RightCol;
    bool LeftCol;

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
                        PatternLeft();
                        break;
                    case 3:
                        PatternRight();
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
                        PatternLeft();
                        break;
                }
                break;
            case 5:
                maxCombo = 5;
                switch (curCombo)
                {
                    case 0:
                        PatternJap();
                        break;
                    case 1:
                        PatternStraight();
                        break;
                    case 2:
                        PatternLeft();
                        break;
                    case 3:
                        PatternRight();
                        break;
                    case 4:
                        PatternLeftUpper();
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
                        PatternLeftUpper();
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
                        PatternLeft();
                        PatternRight();
                        break;
                    case 3:
                        PatternRightUpper();
                        PatternLeftUpper();
                        break;
                }
                break;
        }
    }
    public void InitPos()
    {
        GameObject.Find("RightMitt").transform.DOMove(new Vector3(-3.8f, 0, 3.7f), 0);
        GameObject.Find("RightMitt").transform.DORotate(Vector3.zero, 0);

        GameObject.Find("LeftMitt").transform.DOMove(new Vector3(4, 0, 3.7f), 0);
        GameObject.Find("LeftMitt").transform.DORotate(Vector3.zero, 0);
    }
    public void PatternJap()
    {
        Debug.Log("Jap");
        GameObject.Find("LeftMitt").transform.DOMove(GameObject.Find("Jap").transform.position, 0.3f);
        GameObject.Find("LeftMitt").transform.DORotate(new Vector3(-11.19f, 15.83f, 0), 0);
        InitPos();
    }
    public void PatternStraight()
    {
        Debug.Log("Straight");
        GameObject.Find("RightMitt").transform.DOMove(GameObject.Find("Straight").transform.position, 0.3f);
        GameObject.Find("LeftMitt").transform.DORotate(new Vector3(-9.98f, -26.2f, 0), 0);
        InitPos();
    }
    public void PatternLeft()
    {
        Debug.Log("Left");
        GameObject.Find("LeftMitt").transform.DOMove(GameObject.Find("Left").transform.position, 0.3f);
        GameObject.Find("LeftMitt").transform.DORotate(new Vector3(0, 90, 0), 0.3f);
        InitPos();
    }
    public void PatternRight()
    {
        Debug.Log("Right");
        GameObject.Find("RightMitt").transform.DOMove(GameObject.Find("Right").transform.position, 0.3f);
        GameObject.Find("RightMitt").transform.DORotate(new Vector3(0, -90, 0), 0.3f);
        InitPos();
    }
    public void PatternRightUpper()
    {
        Debug.Log("LeadUpper");
        GameObject.Find("RightMitt").transform.DOMove(GameObject.Find("LeftUpper").transform.position, 0.3f);
        GameObject.Find("RightMitt").transform.DORotate(new Vector3(-67.064f, -51.705f, 30.048f), 0.3f);
    }
    public void PatternLeftUpper()
    {
        Debug.Log("LeadUpper");
        GameObject.Find("LeftMitt").transform.DOMove(GameObject.Find("RightUpper").transform.position, 0.3f);
        GameObject.Find("LeftMitt").transform.DORotate(new Vector3(-69.634f, 52.088f, -45.579f), 0.3f);
    }
    public void PatternDodge()
    {
        Debug.Log("Dodge");
        int DodgeNum = Random.Range(0,2);

        if (DodgeNum == 1)
        {
            GameObject.Find("LeftMitt").transform.DOMove(GameObject.Find("Dodge2").transform.position, 0.3f);
            GameObject.Find("LeftMitt").transform.DORotate(new Vector3(90, 0, 0), 0.3f);
        }
        else
        {
            GameObject.Find("RightMitt").transform.DOMove(GameObject.Find("Dodge1").transform.position, 0.3f);
            GameObject.Find("RightMitt").transform.DORotate(new Vector3(90, 0, 0), 0.3f);
        }
    }
}