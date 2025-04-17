using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Conditions {

	public class HasBeenWarnedCT : ConditionTask {

        /**
        * Author: Michelle Vuong
        * Description: Checks if the student has been warned by the teacher already for eating.
        */

        public BBParameter<bool> isWarned;
		protected override string OnInit(){
			return null;
		}

		protected override bool OnCheck() {
			if(isWarned.value == true)
			{
				return true;
			}
			return false;
		}
	}
}