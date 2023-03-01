// Internal view logic generated from "MainMenuScene.xml"
#region Using Statements
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace Delight
{
    public partial class MainMenuScene : UIView
    {
        #region Constructors

        public MainMenuScene(View parent, View layoutParent = null, string id = null, Template template = null, bool deferInitialization = false) :
            base(parent, layoutParent, id, template ?? MainMenuSceneTemplates.Default, deferInitialization)
        {
            if (deferInitialization)
                return;

            // constructing MainMenuView (MainMenuView1)
            MainMenuView1 = new MainMenuView(this, this, "MainMenuView1", MainMenuView1Template);
            this.AfterInitializeInternal();
        }

        public MainMenuScene() : this(null)
        {
        }

        static MainMenuScene()
        {
            var dependencyProperties = new List<DependencyProperty>();
            DependencyProperties.Add(MainMenuSceneTemplates.Default, dependencyProperties);

            dependencyProperties.Add(MainMenuView1Property);
            dependencyProperties.Add(MainMenuView1TemplateProperty);
        }

        #endregion

        #region Properties

        public readonly static DependencyProperty<MainMenuView> MainMenuView1Property = new DependencyProperty<MainMenuView>("MainMenuView1");
        public MainMenuView MainMenuView1
        {
            get { return MainMenuView1Property.GetValue(this); }
            set { MainMenuView1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> MainMenuView1TemplateProperty = new DependencyProperty<Template>("MainMenuView1Template");
        public Template MainMenuView1Template
        {
            get { return MainMenuView1TemplateProperty.GetValue(this); }
            set { MainMenuView1TemplateProperty.SetValue(this, value); }
        }

        #endregion
    }

    #region Data Templates

    public static class MainMenuSceneTemplates
    {
        #region Properties

        public static Template Default
        {
            get
            {
                return MainMenuScene;
            }
        }

        private static Template _mainMenuScene;
        public static Template MainMenuScene
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuScene == null || _mainMenuScene.CurrentVersion != Template.Version)
#else
                if (_mainMenuScene == null)
#endif
                {
                    _mainMenuScene = new Template(UIViewTemplates.UIView);
#if UNITY_EDITOR
                    _mainMenuScene.Name = "MainMenuScene";
                    _mainMenuScene.LineNumber = 0;
                    _mainMenuScene.LinePosition = 0;
#endif
                    Delight.MainMenuScene.MainMenuView1TemplateProperty.SetDefault(_mainMenuScene, MainMenuSceneMainMenuView1);
                }
                return _mainMenuScene;
            }
        }

        private static Template _mainMenuSceneMainMenuView1;
        public static Template MainMenuSceneMainMenuView1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1 == null || _mainMenuSceneMainMenuView1.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1 == null)
#endif
                {
                    _mainMenuSceneMainMenuView1 = new Template(MainMenuViewTemplates.MainMenuView);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1.Name = "MainMenuSceneMainMenuView1";
                    _mainMenuSceneMainMenuView1.LineNumber = 2;
                    _mainMenuSceneMainMenuView1.LinePosition = 6;
#endif
                    Delight.MainMenuView.Button1TemplateProperty.SetDefault(_mainMenuSceneMainMenuView1, MainMenuSceneMainMenuView1Button1);
                    Delight.MainMenuView.Button2TemplateProperty.SetDefault(_mainMenuSceneMainMenuView1, MainMenuSceneMainMenuView1Button2);
                    Delight.MainMenuView.Button3TemplateProperty.SetDefault(_mainMenuSceneMainMenuView1, MainMenuSceneMainMenuView1Button3);
                }
                return _mainMenuSceneMainMenuView1;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Button1;
        public static Template MainMenuSceneMainMenuView1Button1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Button1 == null || _mainMenuSceneMainMenuView1Button1.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Button1 == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Button1 = new Template(MainMenuViewTemplates.MainMenuViewButton1);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Button1.Name = "MainMenuSceneMainMenuView1Button1";
                    _mainMenuSceneMainMenuView1Button1.LineNumber = 3;
                    _mainMenuSceneMainMenuView1Button1.LinePosition = 6;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuSceneMainMenuView1Button1, MainMenuSceneMainMenuView1Button1Label);
                }
                return _mainMenuSceneMainMenuView1Button1;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Button1Label;
        public static Template MainMenuSceneMainMenuView1Button1Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Button1Label == null || _mainMenuSceneMainMenuView1Button1Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Button1Label == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Button1Label = new Template(MainMenuViewTemplates.MainMenuViewButton1Label);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Button1Label.Name = "MainMenuSceneMainMenuView1Button1Label";
                    _mainMenuSceneMainMenuView1Button1Label.LineNumber = 15;
                    _mainMenuSceneMainMenuView1Button1Label.LinePosition = 4;
#endif
                }
                return _mainMenuSceneMainMenuView1Button1Label;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Button2;
        public static Template MainMenuSceneMainMenuView1Button2
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Button2 == null || _mainMenuSceneMainMenuView1Button2.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Button2 == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Button2 = new Template(MainMenuViewTemplates.MainMenuViewButton2);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Button2.Name = "MainMenuSceneMainMenuView1Button2";
                    _mainMenuSceneMainMenuView1Button2.LineNumber = 6;
                    _mainMenuSceneMainMenuView1Button2.LinePosition = 6;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuSceneMainMenuView1Button2, MainMenuSceneMainMenuView1Button2Label);
                }
                return _mainMenuSceneMainMenuView1Button2;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Button2Label;
        public static Template MainMenuSceneMainMenuView1Button2Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Button2Label == null || _mainMenuSceneMainMenuView1Button2Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Button2Label == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Button2Label = new Template(MainMenuViewTemplates.MainMenuViewButton2Label);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Button2Label.Name = "MainMenuSceneMainMenuView1Button2Label";
                    _mainMenuSceneMainMenuView1Button2Label.LineNumber = 15;
                    _mainMenuSceneMainMenuView1Button2Label.LinePosition = 4;
#endif
                }
                return _mainMenuSceneMainMenuView1Button2Label;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Button3;
        public static Template MainMenuSceneMainMenuView1Button3
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Button3 == null || _mainMenuSceneMainMenuView1Button3.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Button3 == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Button3 = new Template(MainMenuViewTemplates.MainMenuViewButton3);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Button3.Name = "MainMenuSceneMainMenuView1Button3";
                    _mainMenuSceneMainMenuView1Button3.LineNumber = 9;
                    _mainMenuSceneMainMenuView1Button3.LinePosition = 6;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuSceneMainMenuView1Button3, MainMenuSceneMainMenuView1Button3Label);
                }
                return _mainMenuSceneMainMenuView1Button3;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Button3Label;
        public static Template MainMenuSceneMainMenuView1Button3Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Button3Label == null || _mainMenuSceneMainMenuView1Button3Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Button3Label == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Button3Label = new Template(MainMenuViewTemplates.MainMenuViewButton3Label);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Button3Label.Name = "MainMenuSceneMainMenuView1Button3Label";
                    _mainMenuSceneMainMenuView1Button3Label.LineNumber = 15;
                    _mainMenuSceneMainMenuView1Button3Label.LinePosition = 4;
#endif
                }
                return _mainMenuSceneMainMenuView1Button3Label;
            }
        }

        #endregion
    }

    #endregion
}
