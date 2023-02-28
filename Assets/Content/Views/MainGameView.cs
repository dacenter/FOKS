#region Using Statements
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
#endregion

namespace Delight
{
    public partial class MainGameView
    {
        public void Continue()
        {
            Story.Instance.Continue();
        }

        public static string CurrentText;
        public static bool IsShow = true;

        public override void Update()
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                Story.Instance.Continue();
            }
            this.SetPropertyValue(nameof(StoryText), CurrentText);
            
            this.SetPropertyValue(nameof(Showing), IsShow);
            base.Update();
        }
        
        
    }
}
