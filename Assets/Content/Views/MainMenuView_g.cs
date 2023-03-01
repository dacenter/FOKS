// Internal view logic generated from "MainMenuView.xml"
#region Using Statements
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace Delight
{
    public partial class MainMenuView : UIView
    {
        #region Constructors

        public MainMenuView(View parent, View layoutParent = null, string id = null, Template template = null, bool deferInitialization = false) :
            base(parent, layoutParent, id, template ?? MainMenuViewTemplates.Default, deferInitialization)
        {
            if (deferInitialization)
                return;

            // constructing Button (Button1)
            Button1 = new Button(this, this, "Button1", Button1Template);
            Button1.Click.RegisterHandler(this, "StartGame");

            // constructing Button (Button2)
            Button2 = new Button(this, this, "Button2", Button2Template);
            Button2.Click.RegisterHandler(this, "Settings");

            // constructing Button (Button3)
            Button3 = new Button(this, this, "Button3", Button3Template);
            Button3.Click.RegisterHandler(this, "Exit");
            this.AfterInitializeInternal();
        }

        public MainMenuView() : this(null)
        {
        }

        static MainMenuView()
        {
            var dependencyProperties = new List<DependencyProperty>();
            DependencyProperties.Add(MainMenuViewTemplates.Default, dependencyProperties);

            dependencyProperties.Add(Button1Property);
            dependencyProperties.Add(Button1TemplateProperty);
            dependencyProperties.Add(Button2Property);
            dependencyProperties.Add(Button2TemplateProperty);
            dependencyProperties.Add(Button3Property);
            dependencyProperties.Add(Button3TemplateProperty);
        }

        #endregion

        #region Properties

        public readonly static DependencyProperty<Button> Button1Property = new DependencyProperty<Button>("Button1");
        public Button Button1
        {
            get { return Button1Property.GetValue(this); }
            set { Button1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Button1TemplateProperty = new DependencyProperty<Template>("Button1Template");
        public Template Button1Template
        {
            get { return Button1TemplateProperty.GetValue(this); }
            set { Button1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Button> Button2Property = new DependencyProperty<Button>("Button2");
        public Button Button2
        {
            get { return Button2Property.GetValue(this); }
            set { Button2Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Button2TemplateProperty = new DependencyProperty<Template>("Button2Template");
        public Template Button2Template
        {
            get { return Button2TemplateProperty.GetValue(this); }
            set { Button2TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Button> Button3Property = new DependencyProperty<Button>("Button3");
        public Button Button3
        {
            get { return Button3Property.GetValue(this); }
            set { Button3Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Button3TemplateProperty = new DependencyProperty<Template>("Button3Template");
        public Template Button3Template
        {
            get { return Button3TemplateProperty.GetValue(this); }
            set { Button3TemplateProperty.SetValue(this, value); }
        }

        #endregion
    }

    #region Data Templates

    public static class MainMenuViewTemplates
    {
        #region Properties

        public static Template Default
        {
            get
            {
                return MainMenuView;
            }
        }

        private static Template _mainMenuView;
        public static Template MainMenuView
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuView == null || _mainMenuView.CurrentVersion != Template.Version)
#else
                if (_mainMenuView == null)
#endif
                {
                    _mainMenuView = new Template(UIViewTemplates.UIView);
#if UNITY_EDITOR
                    _mainMenuView.Name = "MainMenuView";
                    _mainMenuView.LineNumber = 0;
                    _mainMenuView.LinePosition = 0;
#endif
                    Delight.MainMenuView.Button1TemplateProperty.SetDefault(_mainMenuView, MainMenuViewButton1);
                    Delight.MainMenuView.Button2TemplateProperty.SetDefault(_mainMenuView, MainMenuViewButton2);
                    Delight.MainMenuView.Button3TemplateProperty.SetDefault(_mainMenuView, MainMenuViewButton3);
                }
                return _mainMenuView;
            }
        }

        private static Template _mainMenuViewButton1;
        public static Template MainMenuViewButton1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewButton1 == null || _mainMenuViewButton1.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewButton1 == null)
#endif
                {
                    _mainMenuViewButton1 = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _mainMenuViewButton1.Name = "MainMenuViewButton1";
                    _mainMenuViewButton1.LineNumber = 3;
                    _mainMenuViewButton1.LinePosition = 6;
#endif
                    Delight.Button.BackgroundSpriteProperty.SetDefault(_mainMenuViewButton1, Assets.Sprites["Pxiel Art UI borders_0"]);
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Pressed", _mainMenuViewButton1, new UnityEngine.Color(0.6901961f, 0.1882353f, 0.3607843f, 1f));
                    Delight.Button.WidthProperty.SetDefault(_mainMenuViewButton1, new ElementSize(0.5f, ElementSizeUnit.Percents));
                    Delight.Button.HeightProperty.SetDefault(_mainMenuViewButton1, new ElementSize(75f, ElementSizeUnit.Pixels));
                    Delight.Button.AlignmentProperty.SetDefault(_mainMenuViewButton1, Delight.ElementAlignment.Center);
                    Delight.Button.MarginProperty.SetDefault(_mainMenuViewButton1, new ElementMargin(new ElementSize(10f, ElementSizeUnit.Pixels), new ElementSize(10f, ElementSizeUnit.Pixels), new ElementSize(10f, ElementSizeUnit.Pixels), new ElementSize(10f, ElementSizeUnit.Pixels)));
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuViewButton1, MainMenuViewButton1Label);
                }
                return _mainMenuViewButton1;
            }
        }

        private static Template _mainMenuViewButton1Label;
        public static Template MainMenuViewButton1Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewButton1Label == null || _mainMenuViewButton1Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewButton1Label == null)
#endif
                {
                    _mainMenuViewButton1Label = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _mainMenuViewButton1Label.Name = "MainMenuViewButton1Label";
                    _mainMenuViewButton1Label.LineNumber = 15;
                    _mainMenuViewButton1Label.LinePosition = 4;
#endif
                    Delight.Label.FontSizeProperty.SetDefault(_mainMenuViewButton1Label, 24);
                    Delight.Label.FontColorProperty.SetDefault(_mainMenuViewButton1Label, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontProperty.SetDefault(_mainMenuViewButton1Label, Assets.Fonts["Fifaks10Dev1"]);
                    Delight.Label.FontColorProperty.SetStateDefault("Highlighted", _mainMenuViewButton1Label, new UnityEngine.Color(1f, 0.8941177f, 0.4705882f, 1f));
                    Delight.Label.FontSizeProperty.SetStateDefault("Highlighted", _mainMenuViewButton1Label, 30);
                    Delight.Label.TextProperty.SetDefault(_mainMenuViewButton1Label, "НАЧАТЬ");
                }
                return _mainMenuViewButton1Label;
            }
        }

        private static Template _mainMenuViewButton2;
        public static Template MainMenuViewButton2
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewButton2 == null || _mainMenuViewButton2.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewButton2 == null)
#endif
                {
                    _mainMenuViewButton2 = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _mainMenuViewButton2.Name = "MainMenuViewButton2";
                    _mainMenuViewButton2.LineNumber = 7;
                    _mainMenuViewButton2.LinePosition = 6;
#endif
                    Delight.Button.BackgroundSpriteProperty.SetDefault(_mainMenuViewButton2, Assets.Sprites["Pxiel Art UI borders_0"]);
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Pressed", _mainMenuViewButton2, new UnityEngine.Color(0.6901961f, 0.1882353f, 0.3607843f, 1f));
                    Delight.Button.WidthProperty.SetDefault(_mainMenuViewButton2, new ElementSize(0.2f, ElementSizeUnit.Percents));
                    Delight.Button.HeightProperty.SetDefault(_mainMenuViewButton2, new ElementSize(100f, ElementSizeUnit.Pixels));
                    Delight.Button.AlignmentProperty.SetDefault(_mainMenuViewButton2, Delight.ElementAlignment.BottomLeft);
                    Delight.Button.MarginProperty.SetDefault(_mainMenuViewButton2, new ElementMargin(new ElementSize(50f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(50f, ElementSizeUnit.Pixels)));
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuViewButton2, MainMenuViewButton2Label);
                }
                return _mainMenuViewButton2;
            }
        }

        private static Template _mainMenuViewButton2Label;
        public static Template MainMenuViewButton2Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewButton2Label == null || _mainMenuViewButton2Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewButton2Label == null)
#endif
                {
                    _mainMenuViewButton2Label = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _mainMenuViewButton2Label.Name = "MainMenuViewButton2Label";
                    _mainMenuViewButton2Label.LineNumber = 15;
                    _mainMenuViewButton2Label.LinePosition = 4;
#endif
                    Delight.Label.FontSizeProperty.SetDefault(_mainMenuViewButton2Label, 24);
                    Delight.Label.FontColorProperty.SetDefault(_mainMenuViewButton2Label, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontProperty.SetDefault(_mainMenuViewButton2Label, Assets.Fonts["Fifaks10Dev1"]);
                    Delight.Label.FontColorProperty.SetStateDefault("Highlighted", _mainMenuViewButton2Label, new UnityEngine.Color(1f, 0.8941177f, 0.4705882f, 1f));
                    Delight.Label.FontSizeProperty.SetStateDefault("Highlighted", _mainMenuViewButton2Label, 30);
                    Delight.Label.TextProperty.SetDefault(_mainMenuViewButton2Label, "НАСТРОЙКИ");
                }
                return _mainMenuViewButton2Label;
            }
        }

        private static Template _mainMenuViewButton3;
        public static Template MainMenuViewButton3
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewButton3 == null || _mainMenuViewButton3.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewButton3 == null)
#endif
                {
                    _mainMenuViewButton3 = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _mainMenuViewButton3.Name = "MainMenuViewButton3";
                    _mainMenuViewButton3.LineNumber = 11;
                    _mainMenuViewButton3.LinePosition = 6;
#endif
                    Delight.Button.BackgroundSpriteProperty.SetDefault(_mainMenuViewButton3, Assets.Sprites["Pxiel Art UI borders_0"]);
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Pressed", _mainMenuViewButton3, new UnityEngine.Color(0.6901961f, 0.1882353f, 0.3607843f, 1f));
                    Delight.Button.WidthProperty.SetDefault(_mainMenuViewButton3, new ElementSize(0.2f, ElementSizeUnit.Percents));
                    Delight.Button.HeightProperty.SetDefault(_mainMenuViewButton3, new ElementSize(100f, ElementSizeUnit.Pixels));
                    Delight.Button.AlignmentProperty.SetDefault(_mainMenuViewButton3, Delight.ElementAlignment.BottomRight);
                    Delight.Button.MarginProperty.SetDefault(_mainMenuViewButton3, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(50f, ElementSizeUnit.Pixels), new ElementSize(50f, ElementSizeUnit.Pixels)));
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuViewButton3, MainMenuViewButton3Label);
                }
                return _mainMenuViewButton3;
            }
        }

        private static Template _mainMenuViewButton3Label;
        public static Template MainMenuViewButton3Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewButton3Label == null || _mainMenuViewButton3Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewButton3Label == null)
#endif
                {
                    _mainMenuViewButton3Label = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _mainMenuViewButton3Label.Name = "MainMenuViewButton3Label";
                    _mainMenuViewButton3Label.LineNumber = 15;
                    _mainMenuViewButton3Label.LinePosition = 4;
#endif
                    Delight.Label.FontSizeProperty.SetDefault(_mainMenuViewButton3Label, 24);
                    Delight.Label.FontColorProperty.SetDefault(_mainMenuViewButton3Label, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontProperty.SetDefault(_mainMenuViewButton3Label, Assets.Fonts["Fifaks10Dev1"]);
                    Delight.Label.FontColorProperty.SetStateDefault("Highlighted", _mainMenuViewButton3Label, new UnityEngine.Color(1f, 0.8941177f, 0.4705882f, 1f));
                    Delight.Label.FontSizeProperty.SetStateDefault("Highlighted", _mainMenuViewButton3Label, 30);
                    Delight.Label.TextProperty.SetDefault(_mainMenuViewButton3Label, "ВЫХОД");
                }
                return _mainMenuViewButton3Label;
            }
        }

        #endregion
    }

    #endregion
}
