#region Using Statements
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

#endregion

namespace Delight
{
    public partial class MainMenuView
    {
        public void StartGame()
        {
            var view = new SelectStageView();
            view.Load();
            
            this.Unload();
        }

        public void Settings()
        {
            //TODO
        }

        public void Exit()
        {
            Application.Quit();
        }

    }
}
