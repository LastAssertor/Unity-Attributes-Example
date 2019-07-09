using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LGamekit {

    public sealed class SharedBetweenAnimatorsExampleCounter : MonoBehaviour {

        static SharedBetweenAnimatorsExampleCounter m_Instance;

        public static SharedBetweenAnimatorsExampleCounter Instance {
            get {
                if (m_Instance == null) {
                    m_Instance = FindObjectOfType<SharedBetweenAnimatorsExampleCounter>();
                }
                if (m_Instance == null) {
                    m_Instance = new GameObject(typeof(SharedBetweenAnimatorsExampleCounter).Name).AddComponent<SharedBetweenAnimatorsExampleCounter>();
                    DontDestroyOnLoad(m_Instance.gameObject);
                }
                return m_Instance;
            }
        }

        public List<SharedBetweenAnimatorsExample> StateMachineBehaviours = new List<SharedBetweenAnimatorsExample>();

        public List<Animator> Animators = new List<Animator>();

    }


}
