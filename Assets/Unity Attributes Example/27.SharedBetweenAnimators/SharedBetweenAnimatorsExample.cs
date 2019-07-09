using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LGamekit {

    // SharedBetweenAnimatorsAttribute is an attribute that
    // specify that this StateMachineBehaviour should be instantiate only once and shared among all Animator instance.
    // This attribute reduce the memory footprint for each controller instance.

    // It's up to the programmer to choose which StateMachineBehaviour could use this attribute.
    // Be aware that if your StateMachineBehaviour change some member variable it will affect all other Animator instance using it.
    // See Also: StateMachineBehaviour class.

    [SharedBetweenAnimators]
    public class SharedBetweenAnimatorsExample : StateMachineBehaviour {

        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {

            var Animators = SharedBetweenAnimatorsExampleCounter.Instance.Animators;
            if (!Animators.Contains(animator)) {
                Animators.Add(animator);
            }

            var StateMachineBehaviours = SharedBetweenAnimatorsExampleCounter.Instance.StateMachineBehaviours;
            if (!StateMachineBehaviours.Contains(this)) {
                StateMachineBehaviours.Add(this);
            }
        }

    }

}
