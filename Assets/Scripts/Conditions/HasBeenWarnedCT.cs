using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Conditions {

	public class HasBeenWarnedCT : ConditionTask {

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