using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class SoundDetectedCT : ConditionTask {

        public BBParameter<int> foodSound;

        protected override string OnInit(){
			return null;
		}

		
		protected override void OnEnable() {
			
		}

		//Called whenever the condition gets disabled.
		protected override void OnDisable() {
			
		}

		
		protected override bool OnCheck() {
            Collider[] colliderDetect = Physics.OverlapSphere(new Vector3(0, 0, 0), 20, LayerMask.GetMask("Player"));
            if (Input.GetKeyDown(KeyCode.E))
            {
                for (int i = 0; i < colliderDetect.Length; i++)
                {
					return true;
                }
            }

			return false;
        }

    }
}