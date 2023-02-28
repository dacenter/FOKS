// Internal view logic generated from "MainGameScene.xml"
#region Using Statements
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace Delight
{
    public partial class MainGameScene : UIView
    {
        #region Constructors

        public MainGameScene(View parent, View layoutParent = null, string id = null, Template template = null, bool deferInitialization = false) :
            base(parent, layoutParent, id, template ?? MainGameSceneTemplates.Default, deferInitialization)
        {
            if (deferInitialization)
                return;

            // constructing MainGameView (MainGameView1)
            MainGameView1 = new MainGameView(this, this, "MainGameView1", MainGameView1Template);
            this.AfterInitializeInternal();
        }

        public MainGameScene() : this(null)
        {
        }

        static MainGameScene()
        {
            var dependencyProperties = new List<DependencyProperty>();
            DependencyProperties.Add(MainGameSceneTemplates.Default, dependencyProperties);

            dependencyProperties.Add(MainGameView1Property);
            dependencyProperties.Add(MainGameView1TemplateProperty);
        }

        #endregion

        #region Properties

        public readonly static DependencyProperty<MainGameView> MainGameView1Property = new DependencyProperty<MainGameView>("MainGameView1");
        public MainGameView MainGameView1
        {
            get { return MainGameView1Property.GetValue(this); }
            set { MainGameView1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> MainGameView1TemplateProperty = new DependencyProperty<Template>("MainGameView1Template");
        public Template MainGameView1Template
        {
            get { return MainGameView1TemplateProperty.GetValue(this); }
            set { MainGameView1TemplateProperty.SetValue(this, value); }
        }

        #endregion
    }

    #region Data Templates

    public static class MainGameSceneTemplates
    {
        #region Properties

        public static Template Default
        {
            get
            {
                return MainGameScene;
            }
        }

        private static Template _mainGameScene;
        public static Template MainGameScene
        {
            get
            {
#if UNITY_EDITOR
                if (_mainGameScene == null || _mainGameScene.CurrentVersion != Template.Version)
#else
                if (_mainGameScene == null)
#endif
                {
                    _mainGameScene = new Template(UIViewTemplates.UIView);
#if UNITY_EDITOR
                    _mainGameScene.Name = "MainGameScene";
                    _mainGameScene.LineNumber = 0;
                    _mainGameScene.LinePosition = 0;
#endif
                    Delight.MainGameScene.MainGameView1TemplateProperty.SetDefault(_mainGameScene, MainGameSceneMainGameView1);
                }
                return _mainGameScene;
            }
        }

        private static Template _mainGameSceneMainGameView1;
        public static Template MainGameSceneMainGameView1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainGameSceneMainGameView1 == null || _mainGameSceneMainGameView1.CurrentVersion != Template.Version)
#else
                if (_mainGameSceneMainGameView1 == null)
#endif
                {
                    _mainGameSceneMainGameView1 = new Template(MainGameViewTemplates.MainGameView);
#if UNITY_EDITOR
                    _mainGameSceneMainGameView1.Name = "MainGameSceneMainGameView1";
                    _mainGameSceneMainGameView1.LineNumber = 2;
                    _mainGameSceneMainGameView1.LinePosition = 6;
#endif
                    Delight.MainGameView.Region1TemplateProperty.SetDefault(_mainGameSceneMainGameView1, MainGameSceneMainGameView1Region1);
                    Delight.MainGameView.Label1TemplateProperty.SetDefault(_mainGameSceneMainGameView1, MainGameSceneMainGameView1Label1);
                }
                return _mainGameSceneMainGameView1;
            }
        }

        private static Template _mainGameSceneMainGameView1Region1;
        public static Template MainGameSceneMainGameView1Region1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainGameSceneMainGameView1Region1 == null || _mainGameSceneMainGameView1Region1.CurrentVersion != Template.Version)
#else
                if (_mainGameSceneMainGameView1Region1 == null)
#endif
                {
                    _mainGameSceneMainGameView1Region1 = new Template(MainGameViewTemplates.MainGameViewRegion1);
#if UNITY_EDITOR
                    _mainGameSceneMainGameView1Region1.Name = "MainGameSceneMainGameView1Region1";
                    _mainGameSceneMainGameView1Region1.LineNumber = 2;
                    _mainGameSceneMainGameView1Region1.LinePosition = 6;
#endif
                }
                return _mainGameSceneMainGameView1Region1;
            }
        }

        private static Template _mainGameSceneMainGameView1Label1;
        public static Template MainGameSceneMainGameView1Label1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainGameSceneMainGameView1Label1 == null || _mainGameSceneMainGameView1Label1.CurrentVersion != Template.Version)
#else
                if (_mainGameSceneMainGameView1Label1 == null)
#endif
                {
                    _mainGameSceneMainGameView1Label1 = new Template(MainGameViewTemplates.MainGameViewLabel1);
#if UNITY_EDITOR
                    _mainGameSceneMainGameView1Label1.Name = "MainGameSceneMainGameView1Label1";
                    _mainGameSceneMainGameView1Label1.LineNumber = 3;
                    _mainGameSceneMainGameView1Label1.LinePosition = 10;
#endif
                }
                return _mainGameSceneMainGameView1Label1;
            }
        }

        #endregion
    }

    #endregion
}
