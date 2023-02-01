using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Dialoguesystem2
{
    public class DialogueLine2 : DialogueBaseClass2
    {
        private Text textHolder;

        [Header("Text Options")]
        [SerializeField] private string input;
        [SerializeField]private Color textColor;
        [SerializeField]private Font textFont;

        [Header("Sound")]
        [SerializeField] private AudioClip sound;

        [Header("Time Parameters")]
        [SerializeField] private float delay;

        private void Awake()
        {
            textHolder = GetComponent<Text>();
            StartCoroutine(WriteText(input, textHolder, textColor, textFont, sound, delay));
        }
    }
}
