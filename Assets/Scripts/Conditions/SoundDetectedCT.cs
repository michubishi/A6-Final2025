using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Conditions {

	public class SoundDetectedCT : ConditionTask {

        /**
		 * Author: Michelle Vuong
		 * Description: Detects if the player attempts to eat while in the radius of the teacher.
		 */

        public NavMeshAgent navAgent;

        protected override string OnInit(){
			return null;
		}

        protected override bool OnCheck() {
            Collider[] colliderDetect = Physics.OverlapSphere(navAgent.transform.position, 6, LayerMask.GetMask("Player")); //Create sphere collider detection for the player


            if (Input.GetKeyDown(KeyCode.E)) //checks if the player clicks eats in the collider radius
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