using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageList:MonoBehaviour
{
       [SerializeField]
       private List<Stage> Stages;
       [SerializeField]
       public int CurrentIndex;


       public Stage SelectedStage
       {
              get => Stages[CurrentIndex];
       }

       public bool CanNext => CurrentIndex < Stages.Count - 1;

       public bool CanPrev => CurrentIndex > 0;

       public bool CanLoad => SelectedStage.Active;

       public event Action Changed = delegate {  };

       
       public static StageList Instance => _instance;
       private static StageList _instance;

       private void Awake()
       {
              _instance = this;
       }

       public void SelectNext()
       {
              if (CanNext)
              {
                     CurrentIndex++;
              }
       }

       public void SelectPrev()
       {
              if (CanPrev)
              {
                     CurrentIndex--;
              }
       }

       public void LoadSelected()
       {
              SceneManager.LoadSceneAsync(SelectedStage.SceneIndex);
       }
}