using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions {

	public class HelpStudentCT : ConditionTask {


        /**
		 * Author: Michelle Vuong
		 * Description: Checks if the student has called over the teacher for help.
		 */

        public BBParameter<bool> askedHelp;
		protected override string OnInit(){
			return null;
		}
		protected override bool OnCheck() {
			if(askedHelp.value == true) //checks if the student has called the teacher for help
			{
				return true;
			}
			return false;
		}
	}
}