using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Conditions {

	public class SoundDetectedCT : ConditionTask {

        public BBParameter<int> foodSound;
		public BBParameter<int> heardSound;
		public NavMeshAgent navAgent;

        protected override string OnInit(){
			return null;
		}

		
		protected override void OnEnable() {
			
		}

		//Called whenever the condition gets disabled.
		protected override void OnDisable() {
			
		}

		
		protected override bool OnCheck() {
            Collider[] colliderDetect = Physics.OverlapSphere(new Vector3(navAgent.transform.position.x, navAgent.transform.position.y, navAgent.transform.position.z), 6, LayerMask.GetMask("Player"));

            if (Input.GetKeyDown(KeyCode.E))
            {
                for (int i = 0; i < colliderDetect.Length;)
                {
					return true;
                }
            }

			return false;
        }

		

    }
}