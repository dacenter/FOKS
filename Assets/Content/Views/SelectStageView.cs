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
    public partial class SelectStageView
    {
        public void Select()
        {
            StageList.Instance.LoadSelected();
        }

        public void SelectNextStage()
        {
            StageList.Instance.SelectNext();
            UpdateInfo();
        }

        public void SelectPrevStage()
        {
            StageList.Instance.SelectPrev();
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            this.SetPropertyValue(nameof(NextActive), StageList.Instance.CanNext);
            this.SetPropertyValue(nameof(PrevActive), StageList.Instance.CanPrev);
            this.SetPropertyValue(nameof(StageName), StageList.Instance.SelectedStage.StageName);
            this.SetPropertyValue(nameof(StageActive), StageList.Instance.SelectedStage.Active);
            this.SetPropertyValue(nameof(StageLogo), (SpriteAsset) StageList.Instance.SelectedStage.SceneImage);
            Image1.ImageComponent.material.SetFloat("_Opened", StageList.Instance.SelectedStage.Active?1:0);
        }

      

        protected override void AfterLoad()
        {
            base.AfterLoad();
            
            UpdateInfo();
        }
    }
}
