using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Dialoguesystem2
{
    public class DialogueBaseClass2 : MonoBehaviour
    {
        protected IEnumerator WriteText(string input, Text textHolder, Color textColor, Font textFont)
        {
            textHolder.color = textColor;
            textHolder.font = textFont;
            textHolder.fontSize = 20;
            for (int i = 0; i < input.Length; i++)
            {
                textHolder.text += input[i];
                yield return new WaitForSeconds(0.1f);
            }
        }
    }
}
