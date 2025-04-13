using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Actions {

	public class TeacherWarnAT : ActionTask {

		public BBParameter<bool> isWarned;
		
		protected override string OnInit() {
			return null;
		}

		
		protected override void OnExecute() {
			isWarned.value = true;
			EndAction(true);
		}

		protected override void OnUpdate() {
			
		}

		protected override void OnStop() {
			
		}

		protected override void OnPause() {
			
		}
	}
}