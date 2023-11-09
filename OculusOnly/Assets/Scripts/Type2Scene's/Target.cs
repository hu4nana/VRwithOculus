using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] int score;
    Animator ani;
    [SerializeField] bool isHit = false;
    bool isScored = false;
    bool activation;
    // Start is called before the first frame update
    void Start()
    {
        ani= GetComponent<Animator>();
    }
    public bool GetIsScored()
    {
        return isScored;
    }
    public void SetIsScored(bool value)
    {
        isScored = value;
    }
    public int GetScore()
    {
        return score;
        //return stat.GetScore();
    }
    public void SetScore(int value)
    {
        score = value;
        //stat.SetScore(value);
    }
    public bool GetActivation()
    {
        return activation;
        //return stat.GetActivation();
    }
    public void SetActivation(bool act)
    {
        activation = act;
        //stat.SetActivation(act);
    }
    public bool GetIsHit()
    {
        return isHit;
    }
    public void SetIsHit(bool value)
    {
        isHit = value;
    }
    public void TargetActivation()
    {
        ani.SetBool("activation", true);
        if (ani.GetCurrentAnimatorStateInfo(0).normalizedTime>=1f)
        {
            SetActivation(true);
            //Debug.Log(stat.GetActivation());
        }
    }
    public void TargetDeActivation()
    {
        SetActivation(false);
        ani.SetBool("activation", false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (GetActivation())
        {
            isHit = true;
            Debug.Log("충돌함함함함함함하맣하");
        }
    }
}
