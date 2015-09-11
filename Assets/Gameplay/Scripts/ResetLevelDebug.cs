// <copyright> Copyright (c) All Rights Reserved </copyright>
// <author>Michele Pirovano</author>

#if UNITY_EDITOR
#define DEBUG
#endif

namespace Cat.Debugging
{
    using UnityEngine;
    using System.Collections;


    public class ResetLevelDebug : MonoBehaviour
    {
        public KeyCode resetKey = KeyCode.R;

        [System.Diagnostics.Conditional("DEBUG")]
        void Update()
        {
            if (Input.GetKeyDown(resetKey)) Application.LoadLevel(Application.loadedLevel);
        }

    }
}