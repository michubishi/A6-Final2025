using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class CallTeacherAT : ActionTask {
        /**
        * Author: Michelle Vuong
        * Description: This AT makes the student call the teacher over.
        */
        public BBParameter<bool> askedHelp;
		public GameObject helpSpeech;
		public float elaspedTime;
		public GameObject thankSpeech;
		
		protected override string OnInit() {
			return null;
		}
		
		protected override void OnUpdate() {
            elaspedTime += Time.deltaTime;
			helpSpeech.SetActive(true); //show telegraphing speech that student needs help.
            askedHelp.value = true; //set global variable of asking for help.

			if(elapsedTime >= 8) //if it has been 8 seconds passed, show the thank you speech
			{
                helpSpeech.SetActive(false);
                thankSpeech.SetActive(true);
			}

            if (elapsedTime >= 10) //if it has been 10 seconds
			{
				thankSpeech.SetActive(false); //disable the speech and the global variable value
				askedHelp.value = false;
                EndAction(true);
            }
			
			
		}

	}
}