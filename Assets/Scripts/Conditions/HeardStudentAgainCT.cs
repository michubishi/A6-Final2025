using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Unity.VisualScripting;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions {

	public class HeardStudentAgainCT : ConditionTask {


        /**
		 * Author: Michelle Vuong
		 * Description: Checks if it has been 17 seconds to enable the working mode for the teacher.
		 */

        public BBParameter<bool> ateAgain;

		protected override string OnInit(){
			return null;
		}

		protected override bool OnCheck() {
			if (ateAgain.value == true)
			{
				ateAgain.value = false;
				return true;
			}
			return false;
		}
	}
}