using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace Oculus.Interaction
{
    public class MetronomeKeypad : MonoBehaviour
    {


        public string digit;
        public TMP_Text digitText;
        public TMP_Text bpmText;
        public MetronomeRoutine metRoutineScript;

        
        public void Start()
        {

            if (digit == "-1")
            {
                digitText.text = "X";
            }
            else if (digit == "-2")
            {
                digitText.text = "OFF";
            }
            else
            {
                digitText.text = digit;
            }
        }

        //managing metronome from presses of keypad
        public void keypadPressed()
        {
            if (int.Parse(digit) > -1)
            {
                bpmText.text = bpmText.text + digit;
            }
            else if (int.Parse(digit) == -2)
            {
                string prevState = digitText.text;
                digitText.text = prevState == "OFF" ? "ON" : "OFF";

                GameObject buttonVisual = this.transform.parent.gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
                buttonVisual.name = "AYBBDAADA";

                InteractableColorVisual icvScript = buttonVisual.GetComponent<InteractableColorVisual>();
                Debug.Log(icvScript);
                Color nextColor = prevState == "OFF" ? new Color(0.0f,1.0f,0.0f,0.137f) : new Color(1.0f,0.137f,0.137f,0.137f);
                Debug.Log(nextColor);
                icvScript.SetColor(nextColor);

                metRoutineScript.toggleMetronomeCoroutine();
            }
            else if (bpmText.text.Length > 4)
            {
                string currState = bpmText.text;
                bpmText.text = currState.Remove(currState.Length-1);
            }
        }

    }
}
