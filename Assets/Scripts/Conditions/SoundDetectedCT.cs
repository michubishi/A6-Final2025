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

        protected override bool OnCheck() {
            Collider[] colliderDetect = Physics.OverlapSphere(navAgent.transform.position, 6, LayerMask.GetMask("Player"));


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