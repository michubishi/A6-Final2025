using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Conditions {

	public class SuspiciousCT : ConditionTask {

		public BBParameter<float> heardSound;
		
		protected override string OnInit(){
			return null;
		}


		protected override bool OnCheck() {
			if(heardSound.value >= 50)
			{
				return true;
			}
			return false;
		}
	}
}