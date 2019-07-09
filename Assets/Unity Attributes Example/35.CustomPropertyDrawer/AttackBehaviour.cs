using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBehaviour : StateMachineBehaviour
{
    //public GameObject particle;
    [Range(1, 5)]
    public float radius;
    [Range(0, 1999)]
    public float power;

    //protected GameObject clone;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //clone = Instantiate(particle, animator.rootPosition, Quaternion.identity) as GameObject;
        //Rigidbody rb = clone.GetComponent<Rigidbody>();
        //rb.AddExplosionForce(power, animator.rootPosition, radius, 3.0f);
        //Debug.Log("On Attack Enter ");
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //Destroy(clone);
        //Debug.Log("On Attack Exit ");
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //Debug.Log("On Attack Update ");
    }

    override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //Debug.Log("On Attack Move ");
    }

    override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //Debug.Log("On Attack IK ");
    }


    [BeforeRenderOrder(2000)]
    void BeforeRender()
    {
        Debug.LogWarning(2000);
    }
}
