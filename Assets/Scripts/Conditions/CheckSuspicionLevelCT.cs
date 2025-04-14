using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Conditions {

	public class CheckSuspicionLevelCT : ConditionTask {

		public BBParameter<float> susLevel;
		public float soundThres;
		protected override string OnInit(){
			return null;
		}

		protected override bool OnCheck() {
			if(susLevel.value <= soundThres)
			{
				return true;
			}
			return false;
		}
	}
}