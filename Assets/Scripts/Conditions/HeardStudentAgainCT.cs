using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Unity.VisualScripting;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions {

	public class HeardStudentAgainCT : ConditionTask {


        /**
		 * Author: Michelle Vuong
		 * Description: Checks if the player attempted to eat again after already receiving a warning.
		 */

        public BBParameter<bool> ateAgain;

		protected override string OnInit(){
			return null;
		}

		protected override bool OnCheck() {
			if (ateAgain.value == true) //checks if they ate again
			{
				ateAgain.value = false; //reset the value
				return true;
			}
			return false;
		}
	}
}