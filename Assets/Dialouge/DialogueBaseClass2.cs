using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Dialoguesystem2
{
    public class DialogueBaseClass2 : MonoBehaviour
    {
        public bool Finished { get; private set; }

        protected IEnumerator WriteText(string input, Text textHolder, Color textColor, Font textFont, AudioClip sound, float delay, float delayBetweenLines)
        {
            textHolder.color = textColor;
            textHolder.font = textFont;
            for (int i = 0; i < input.Length; i++)
            {
                textHolder.text += input[i];
                SoundManager.instance.PlaySound(sound);
                yield return new WaitForSeconds(delay);
            }
             yield return new WaitForSeconds(delayBetweenLines);
            //yield return new WaitUntil(() => Input.GetButtonUp("Space"));
            Finished = true;
        }
    }
}
