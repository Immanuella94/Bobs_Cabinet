using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace M_DialougeSystem
{
    public class M_DialougeLine : M_DialougeBaseClass
    {
        private Text textHolder;
        [SerializeField] private string input;

        private void Awake()
        {
            textHolder = GetComponent<Text>();

            StartCoroutine(writeText(input, textHolder));
        }
    }
}

