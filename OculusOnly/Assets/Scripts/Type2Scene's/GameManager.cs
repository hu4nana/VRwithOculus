using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> matrix = new List<GameObject>();

    [SerializeField] int score = 0;
    List<Target> target = new List<Target> ();

    // ∏Ó ∞≥ ªÃ¿ª ∞Õ¿Œ∞°?
    int drawCount = 0;
    // ªÃ¿∫ º˝¿⁄ ¿˙¿Â
    List<int> number = new List<int> ();
    private void Awake()
    {
        for (int i = 0; i < matrix.Count; i++)
        {
            target.Add(matrix[i].GetComponent<Target>());
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            SetAGame();
        }


        foreach (int i in number)
        {
            if (!target[i].GetIsScored()&&target[i].GetIsHit())
            {
                score += target[i].GetScore();
                target[i].SetIsScored(true);
            }
        }
    }

    void SetAGame()
    {
        SetDrawCount();
        DecideTargetNumber();
        TargetsActivation();

    }
    int SetDrawCount()
    {
        number.Clear();
        drawCount = Random.Range(1, matrix.Count);
        return drawCount;
    }
    void DecideTargetNumber()
    {
        Debug.Log("ªÃ±‚ »Ωºˆ = " + drawCount);
        for(int i = 0; i < drawCount; i++)
        {
            number.Add(new System.Random().Next(0,target.Count));
            Debug.Log("ªÃ»˘ º˝¿⁄ = " + number[i]);
        }
    }
    void TargetsActivation()
    {
        for(int i=0; i<number.Count-1; i++)
        {
            target[i].SetIsHit(false);
            target[i].SetType(Type.Target);
            target[i].SetIsScored(false);
            target[i].TargetActivation();
        }
        target[number.Count-1].SetType(Type.Attack);
        target[number.Count - 1].TargetActivation();
    }
}
