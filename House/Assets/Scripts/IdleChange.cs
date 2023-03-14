using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleChange : StateMachineBehaviour
{
    [SerializeField]
    private float timeChange;

    [SerializeField]
    private int numberOfAnimation;

    private bool isAnimated;
    private float idleTime;
    private int idleAnimation;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        ResetIdle();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(isAnimated == false)
        {
            idleTime += Time.deltaTime;

            if (idleTime > timeChange && stateInfo.normalizedTime % 1 < 0.02f)
            {
                isAnimated = true;
                idleAnimation = Random.Range(1, numberOfAnimation + 1);
                idleAnimation = idleAnimation * 2 - 1;

                animator.SetFloat("idle_type", idleAnimation - 1);
                
            }
        }
        else if(stateInfo.normalizedTime%1 > 0.98)
        {
            ResetIdle();
        }
        animator.SetFloat("idle_type", idleAnimation, 0.5f, Time.deltaTime);
    }
    private void ResetIdle()
    {
        if (isAnimated)
        {
            idleAnimation--;
        }
        isAnimated = false;
        idleTime = 0;
       
       
    }
    
}
