using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Conditions {

	public class SuspiciousCT : ConditionTask {

		public BBParameter<float> heardSound;
		
		protected override string OnInit(){
			return null;
		}


		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck() {
			if(heardSound.value >= 50)
			{
				return true;
			}
			return false;
		}
	}
}