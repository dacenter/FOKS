// Internal view logic generated from "MainGameView.xml"
#region Using Statements
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace Delight
{
    public partial class MainGameView : UIView
    {
        #region Constructors

        public MainGameView(View parent, View layoutParent = null, string id = null, Template template = null, bool deferInitialization = false) :
            base(parent, layoutParent, id, template ?? MainGameViewTemplates.Default, deferInitialization)
        {
            if (deferInitialization)
                return;

            // constructing Region (Region1)
            Region1 = new Region(this, this, "Region1", Region1Template);

            // binding <Region IsVisible="{Showing}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "Showing" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "Region1", "IsVisible" }, new List<Func<object>> { () => this, () => Region1 }), () => Region1.IsVisible = Showing, () => { }, false));
            Label1 = new Label(this, Region1.Content, "Label1", Label1Template);
            Label1.Click.RegisterHandler(this, "Continue");

            // binding <Label Text="{StoryText}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "StoryText" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "Label1", "Text" }, new List<Func<object>> { () => this, () => Label1 }), () => Label1.Text = StoryText, () => { }, false));
            this.AfterInitializeInternal();
        }

        public MainGameView() : this(null)
        {
        }

        static MainGameView()
        {
            var dependencyProperties = new List<DependencyProperty>();
            DependencyProperties.Add(MainGameViewTemplates.Default, dependencyProperties);

            dependencyProperties.Add(StoryTextProperty);
            dependencyProperties.Add(ShowingProperty);
            dependencyProperties.Add(Region1Property);
            dependencyProperties.Add(Region1TemplateProperty);
            dependencyProperties.Add(Label1Property);
            dependencyProperties.Add(Label1TemplateProperty);
        }

        #endregion

        #region Properties

        public readonly static DependencyProperty<System.String> StoryTextProperty = new DependencyProperty<System.String>("StoryText");
        public System.String StoryText
        {
            get { return StoryTextProperty.GetValue(this); }
            set { StoryTextProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<System.Boolean> ShowingProperty = new DependencyProperty<System.Boolean>("Showing");
        public System.Boolean Showing
        {
            get { return ShowingProperty.GetValue(this); }
            set { ShowingProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> Region1Property = new DependencyProperty<Region>("Region1");
        public Region Region1
        {
            get { return Region1Property.GetValue(this); }
            set { Region1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Region1TemplateProperty = new DependencyProperty<Template>("Region1Template");
        public Template Region1Template
        {
            get { return Region1TemplateProperty.GetValue(this); }
            set { Region1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> Label1Property = new DependencyProperty<Label>("Label1");
        public Label Label1
        {
            get { return Label1Property.GetValue(this); }
            set { Label1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Label1TemplateProperty = new DependencyProperty<Template>("Label1Template");
        public Template Label1Template
        {
            get { return Label1TemplateProperty.GetValue(this); }
            set { Label1TemplateProperty.SetValue(this, value); }
        }

        #endregion
    }

    #region Data Templates

    public static class MainGameViewTemplates
    {
        #region Properties

        public static Template Default
        {
            get
            {
                return MainGameView;
            }
        }

        private static Template _mainGameView;
        public static Template MainGameView
        {
            get
            {
#if UNITY_EDITOR
                if (_mainGameView == null || _mainGameView.CurrentVersion != Template.Version)
#else
                if (_mainGameView == null)
#endif
                {
                    _mainGameView = new Template(UIViewTemplates.UIView);
#if UNITY_EDITOR
                    _mainGameView.Name = "MainGameView";
                    _mainGameView.LineNumber = 0;
                    _mainGameView.LinePosition = 0;
#endif
                    Delight.MainGameView.ShowingProperty.SetDefault(_mainGameView, true);
                    Delight.MainGameView.EnableScriptEventsProperty.SetDefault(_mainGameView, true);
                    Delight.MainGameView.Region1TemplateProperty.SetDefault(_mainGameView, MainGameViewRegion1);
                    Delight.MainGameView.Label1TemplateProperty.SetDefault(_mainGameView, MainGameViewLabel1);
                }
                return _mainGameView;
            }
        }

        private static Template _mainGameViewRegion1;
        public static Template MainGameViewRegion1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainGameViewRegion1 == null || _mainGameViewRegion1.CurrentVersion != Template.Version)
#else
                if (_mainGameViewRegion1 == null)
#endif
                {
                    _mainGameViewRegion1 = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _mainGameViewRegion1.Name = "MainGameViewRegion1";
                    _mainGameViewRegion1.LineNumber = 2;
                    _mainGameViewRegion1.LinePosition = 6;
#endif
                    Delight.Region.WidthProperty.SetDefault(_mainGameViewRegion1, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.Region.HeightProperty.SetDefault(_mainGameViewRegion1, new ElementSize(0.25f, ElementSizeUnit.Percents));
                    Delight.Region.BackgroundSpriteProperty.SetDefault(_mainGameViewRegion1, Assets.Sprites["Pxiel Art UI borders_0"]);
                    Delight.Region.AlignmentProperty.SetDefault(_mainGameViewRegion1, Delight.ElementAlignment.Top);
                    Delight.Region.MarginProperty.SetDefault(_mainGameViewRegion1, new ElementMargin(new ElementSize(10f, ElementSizeUnit.Pixels), new ElementSize(10f, ElementSizeUnit.Pixels), new ElementSize(10f, ElementSizeUnit.Pixels), new ElementSize(10f, ElementSizeUnit.Pixels)));
                    Delight.Region.IsVisibleProperty.SetHasBinding(_mainGameViewRegion1);
                }
                return _mainGameViewRegion1;
            }
        }

        private static Template _mainGameViewLabel1;
        public static Template MainGameViewLabel1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainGameViewLabel1 == null || _mainGameViewLabel1.CurrentVersion != Template.Version)
#else
                if (_mainGameViewLabel1 == null)
#endif
                {
                    _mainGameViewLabel1 = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _mainGameViewLabel1.Name = "MainGameViewLabel1";
                    _mainGameViewLabel1.LineNumber = 3;
                    _mainGameViewLabel1.LinePosition = 10;
#endif
                    Delight.Label.FontColorProperty.SetDefault(_mainGameViewLabel1, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.WidthProperty.SetDefault(_mainGameViewLabel1, new ElementSize(0.8f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_mainGameViewLabel1, new ElementSize(0.6f, ElementSizeUnit.Percents));
                    Delight.Label.TextAlignmentProperty.SetDefault(_mainGameViewLabel1, Delight.ElementAlignment.TopLeft);
                    Delight.Label.FontSizeProperty.SetDefault(_mainGameViewLabel1, 24);
                    Delight.Label.FontProperty.SetDefault(_mainGameViewLabel1, Assets.Fonts["Fifaks10Dev1"]);
                    Delight.Label.TextProperty.SetHasBinding(_mainGameViewLabel1);
                }
                return _mainGameViewLabel1;
            }
        }

        #endregion
    }

    #endregion
}
