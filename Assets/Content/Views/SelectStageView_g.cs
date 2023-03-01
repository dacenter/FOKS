// Internal view logic generated from "SelectStageView.xml"
#region Using Statements
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace Delight
{
    public partial class SelectStageView : UIView
    {
        #region Constructors

        public SelectStageView(View parent, View layoutParent = null, string id = null, Template template = null, bool deferInitialization = false) :
            base(parent, layoutParent, id, template ?? SelectStageViewTemplates.Default, deferInitialization)
        {
            if (deferInitialization)
                return;

            // constructing Button (Button1)
            Button1 = new Button(this, this, "Button1", Button1Template);
            Button1.Click.RegisterHandler(this, "Select");

            // binding <Button Text="{StageName}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "StageName" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "Button1", "Text" }, new List<Func<object>> { () => this, () => Button1 }), () => Button1.Text = StageName, () => { }, false));

            // binding <Button IsDisabled="{!StageActive}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "StageActive" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "Button1", "IsDisabled" }, new List<Func<object>> { () => this, () => Button1 }), () => Button1.IsDisabled = !StageActive, () => { }, false));
            Image1 = new Image(this, Button1.Content, "Image1", Image1Template);

            // binding <Image Sprite="{StageLogo}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "StageLogo" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "Image1", "Sprite" }, new List<Func<object>> { () => this, () => Image1 }), () => Image1.Sprite = StageLogo, () => { }, false));

            // constructing Label (Label1)
            Label1 = new Label(this, this, "Label1", Label1Template);

            // binding <Label Text="{StageName}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "StageName" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "Label1", "Text" }, new List<Func<object>> { () => this, () => Label1 }), () => Label1.Text = StageName, () => { }, false));

            // constructing Button (Button2)
            Button2 = new Button(this, this, "Button2", Button2Template);
            Button2.Click.RegisterHandler(this, "SelectPrevStage");

            // binding <Button IsVisible="{PrevActive}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "PrevActive" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "Button2", "IsVisible" }, new List<Func<object>> { () => this, () => Button2 }), () => Button2.IsVisible = PrevActive, () => { }, false));

            // constructing Button (Button3)
            Button3 = new Button(this, this, "Button3", Button3Template);
            Button3.Click.RegisterHandler(this, "SelectNextStage");

            // binding <Button IsVisible="{NextActive}">
            Bindings.Add(new Binding(new List<BindingPath> { new BindingPath(new List<string> { "NextActive" }, new List<Func<object>> { () => this }) }, new BindingPath(new List<string> { "Button3", "IsVisible" }, new List<Func<object>> { () => this, () => Button3 }), () => Button3.IsVisible = NextActive, () => { }, false));
            this.AfterInitializeInternal();
        }

        public SelectStageView() : this(null)
        {
        }

        static SelectStageView()
        {
            var dependencyProperties = new List<DependencyProperty>();
            DependencyProperties.Add(SelectStageViewTemplates.Default, dependencyProperties);

            dependencyProperties.Add(PrevActiveProperty);
            dependencyProperties.Add(NextActiveProperty);
            dependencyProperties.Add(StageNameProperty);
            dependencyProperties.Add(StageActiveProperty);
            dependencyProperties.Add(StageLogoProperty);
            dependencyProperties.Add(Button1Property);
            dependencyProperties.Add(Button1TemplateProperty);
            dependencyProperties.Add(Image1Property);
            dependencyProperties.Add(Image1TemplateProperty);
            dependencyProperties.Add(Label1Property);
            dependencyProperties.Add(Label1TemplateProperty);
            dependencyProperties.Add(Button2Property);
            dependencyProperties.Add(Button2TemplateProperty);
            dependencyProperties.Add(Button3Property);
            dependencyProperties.Add(Button3TemplateProperty);
        }

        #endregion

        #region Properties

        public readonly static DependencyProperty<System.Boolean> PrevActiveProperty = new DependencyProperty<System.Boolean>("PrevActive");
        public System.Boolean PrevActive
        {
            get { return PrevActiveProperty.GetValue(this); }
            set { PrevActiveProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<System.Boolean> NextActiveProperty = new DependencyProperty<System.Boolean>("NextActive");
        public System.Boolean NextActive
        {
            get { return NextActiveProperty.GetValue(this); }
            set { NextActiveProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<System.String> StageNameProperty = new DependencyProperty<System.String>("StageName");
        public System.String StageName
        {
            get { return StageNameProperty.GetValue(this); }
            set { StageNameProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<System.Boolean> StageActiveProperty = new DependencyProperty<System.Boolean>("StageActive");
        public System.Boolean StageActive
        {
            get { return StageActiveProperty.GetValue(this); }
            set { StageActiveProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<SpriteAsset> StageLogoProperty = new DependencyProperty<SpriteAsset>("StageLogo");
        public SpriteAsset StageLogo
        {
            get { return StageLogoProperty.GetValue(this); }
            set { StageLogoProperty.SetValue(this, value); }
        }

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

        public readonly static DependencyProperty<Image> Image1Property = new DependencyProperty<Image>("Image1");
        public Image Image1
        {
            get { return Image1Property.GetValue(this); }
            set { Image1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Image1TemplateProperty = new DependencyProperty<Template>("Image1Template");
        public Template Image1Template
        {
            get { return Image1TemplateProperty.GetValue(this); }
            set { Image1TemplateProperty.SetValue(this, value); }
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

    public static class SelectStageViewTemplates
    {
        #region Properties

        public static Template Default
        {
            get
            {
                return SelectStageView;
            }
        }

        private static Template _selectStageView;
        public static Template SelectStageView
        {
            get
            {
#if UNITY_EDITOR
                if (_selectStageView == null || _selectStageView.CurrentVersion != Template.Version)
#else
                if (_selectStageView == null)
#endif
                {
                    _selectStageView = new Template(UIViewTemplates.UIView);
#if UNITY_EDITOR
                    _selectStageView.Name = "SelectStageView";
                    _selectStageView.LineNumber = 0;
                    _selectStageView.LinePosition = 0;
#endif
                    Delight.SelectStageView.PrevActiveProperty.SetDefault(_selectStageView, true);
                    Delight.SelectStageView.NextActiveProperty.SetDefault(_selectStageView, true);
                    Delight.SelectStageView.Button1TemplateProperty.SetDefault(_selectStageView, SelectStageViewButton1);
                    Delight.SelectStageView.Image1TemplateProperty.SetDefault(_selectStageView, SelectStageViewImage1);
                    Delight.SelectStageView.Label1TemplateProperty.SetDefault(_selectStageView, SelectStageViewLabel1);
                    Delight.SelectStageView.Button2TemplateProperty.SetDefault(_selectStageView, SelectStageViewButton2);
                    Delight.SelectStageView.Button3TemplateProperty.SetDefault(_selectStageView, SelectStageViewButton3);
                }
                return _selectStageView;
            }
        }

        private static Template _selectStageViewButton1;
        public static Template SelectStageViewButton1
        {
            get
            {
#if UNITY_EDITOR
                if (_selectStageViewButton1 == null || _selectStageViewButton1.CurrentVersion != Template.Version)
#else
                if (_selectStageViewButton1 == null)
#endif
                {
                    _selectStageViewButton1 = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _selectStageViewButton1.Name = "SelectStageViewButton1";
                    _selectStageViewButton1.LineNumber = 3;
                    _selectStageViewButton1.LinePosition = 6;
#endif
                    Delight.Button.BackgroundSpriteProperty.SetDefault(_selectStageViewButton1, Assets.Sprites["Pxiel Art UI borders_0"]);
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Pressed", _selectStageViewButton1, new UnityEngine.Color(0.6901961f, 0.1882353f, 0.3607843f, 1f));
                    Delight.Button.WidthProperty.SetDefault(_selectStageViewButton1, new ElementSize(0.75f, ElementSizeUnit.Percents));
                    Delight.Button.HeightProperty.SetDefault(_selectStageViewButton1, new ElementSize(0.8f, ElementSizeUnit.Percents));
                    Delight.Button.AlignmentProperty.SetDefault(_selectStageViewButton1, Delight.ElementAlignment.Center);
                    Delight.Button.MarginProperty.SetDefault(_selectStageViewButton1, new ElementMargin(new ElementSize(20f, ElementSizeUnit.Pixels), new ElementSize(20f, ElementSizeUnit.Pixels), new ElementSize(20f, ElementSizeUnit.Pixels), new ElementSize(20f, ElementSizeUnit.Pixels)));
                    Delight.Button.IsDisabledProperty.SetHasBinding(_selectStageViewButton1);
                    Delight.Button.LabelTemplateProperty.SetDefault(_selectStageViewButton1, SelectStageViewButton1Label);
                }
                return _selectStageViewButton1;
            }
        }

        private static Template _selectStageViewButton1Label;
        public static Template SelectStageViewButton1Label
        {
            get
            {
#if UNITY_EDITOR
                if (_selectStageViewButton1Label == null || _selectStageViewButton1Label.CurrentVersion != Template.Version)
#else
                if (_selectStageViewButton1Label == null)
#endif
                {
                    _selectStageViewButton1Label = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _selectStageViewButton1Label.Name = "SelectStageViewButton1Label";
                    _selectStageViewButton1Label.LineNumber = 15;
                    _selectStageViewButton1Label.LinePosition = 4;
#endif
                    Delight.Label.FontSizeProperty.SetDefault(_selectStageViewButton1Label, 24);
                    Delight.Label.FontColorProperty.SetDefault(_selectStageViewButton1Label, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontProperty.SetDefault(_selectStageViewButton1Label, Assets.Fonts["Fifaks10Dev1"]);
                    Delight.Label.FontColorProperty.SetStateDefault("Highlighted", _selectStageViewButton1Label, new UnityEngine.Color(1f, 0.8941177f, 0.4705882f, 1f));
                    Delight.Label.FontSizeProperty.SetStateDefault("Highlighted", _selectStageViewButton1Label, 30);
                    Delight.Label.TextProperty.SetHasBinding(_selectStageViewButton1Label);
                }
                return _selectStageViewButton1Label;
            }
        }

        private static Template _selectStageViewImage1;
        public static Template SelectStageViewImage1
        {
            get
            {
#if UNITY_EDITOR
                if (_selectStageViewImage1 == null || _selectStageViewImage1.CurrentVersion != Template.Version)
#else
                if (_selectStageViewImage1 == null)
#endif
                {
                    _selectStageViewImage1 = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _selectStageViewImage1.Name = "SelectStageViewImage1";
                    _selectStageViewImage1.LineNumber = 6;
                    _selectStageViewImage1.LinePosition = 10;
#endif
                    Delight.Image.WidthProperty.SetDefault(_selectStageViewImage1, new ElementSize(0.9f, ElementSizeUnit.Percents));
                    Delight.Image.HeightProperty.SetDefault(_selectStageViewImage1, new ElementSize(0.9f, ElementSizeUnit.Percents));
                    Delight.Image.PreserveAspectProperty.SetDefault(_selectStageViewImage1, true);
                    Delight.Image.MaterialProperty.SetDefault(_selectStageViewImage1, Assets.Materials["StageLogoMaterial"]);
                    Delight.Image.SpriteProperty.SetHasBinding(_selectStageViewImage1);
                }
                return _selectStageViewImage1;
            }
        }

        private static Template _selectStageViewLabel1;
        public static Template SelectStageViewLabel1
        {
            get
            {
#if UNITY_EDITOR
                if (_selectStageViewLabel1 == null || _selectStageViewLabel1.CurrentVersion != Template.Version)
#else
                if (_selectStageViewLabel1 == null)
#endif
                {
                    _selectStageViewLabel1 = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _selectStageViewLabel1.Name = "SelectStageViewLabel1";
                    _selectStageViewLabel1.LineNumber = 8;
                    _selectStageViewLabel1.LinePosition = 6;
#endif
                    Delight.Label.FontSizeProperty.SetDefault(_selectStageViewLabel1, 24);
                    Delight.Label.FontColorProperty.SetDefault(_selectStageViewLabel1, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontProperty.SetDefault(_selectStageViewLabel1, Assets.Fonts["Fifaks10Dev1"]);
                    Delight.Label.WidthProperty.SetDefault(_selectStageViewLabel1, new ElementSize(0.5f, ElementSizeUnit.Percents));
                    Delight.Label.HeightProperty.SetDefault(_selectStageViewLabel1, new ElementSize(100f, ElementSizeUnit.Pixels));
                    Delight.Label.AlignmentProperty.SetDefault(_selectStageViewLabel1, Delight.ElementAlignment.Bottom);
                    Delight.Label.MarginProperty.SetDefault(_selectStageViewLabel1, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(50f, ElementSizeUnit.Pixels)));
                    Delight.Label.TextProperty.SetHasBinding(_selectStageViewLabel1);
                }
                return _selectStageViewLabel1;
            }
        }

        private static Template _selectStageViewButton2;
        public static Template SelectStageViewButton2
        {
            get
            {
#if UNITY_EDITOR
                if (_selectStageViewButton2 == null || _selectStageViewButton2.CurrentVersion != Template.Version)
#else
                if (_selectStageViewButton2 == null)
#endif
                {
                    _selectStageViewButton2 = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _selectStageViewButton2.Name = "SelectStageViewButton2";
                    _selectStageViewButton2.LineNumber = 9;
                    _selectStageViewButton2.LinePosition = 6;
#endif
                    Delight.Button.BackgroundSpriteProperty.SetDefault(_selectStageViewButton2, Assets.Sprites["Pxiel Art UI borders_0"]);
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Pressed", _selectStageViewButton2, new UnityEngine.Color(0.6901961f, 0.1882353f, 0.3607843f, 1f));
                    Delight.Button.WidthProperty.SetDefault(_selectStageViewButton2, new ElementSize(0.1f, ElementSizeUnit.Percents));
                    Delight.Button.HeightProperty.SetDefault(_selectStageViewButton2, new ElementSize(0.1f, ElementSizeUnit.Percents));
                    Delight.Button.AlignmentProperty.SetDefault(_selectStageViewButton2, Delight.ElementAlignment.Left);
                    Delight.Button.MarginProperty.SetDefault(_selectStageViewButton2, new ElementMargin(new ElementSize(50f, ElementSizeUnit.Pixels), new ElementSize(20f, ElementSizeUnit.Pixels), new ElementSize(20f, ElementSizeUnit.Pixels), new ElementSize(20f, ElementSizeUnit.Pixels)));
                    Delight.Button.IsVisibleProperty.SetHasBinding(_selectStageViewButton2);
                    Delight.Button.LabelTemplateProperty.SetDefault(_selectStageViewButton2, SelectStageViewButton2Label);
                }
                return _selectStageViewButton2;
            }
        }

        private static Template _selectStageViewButton2Label;
        public static Template SelectStageViewButton2Label
        {
            get
            {
#if UNITY_EDITOR
                if (_selectStageViewButton2Label == null || _selectStageViewButton2Label.CurrentVersion != Template.Version)
#else
                if (_selectStageViewButton2Label == null)
#endif
                {
                    _selectStageViewButton2Label = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _selectStageViewButton2Label.Name = "SelectStageViewButton2Label";
                    _selectStageViewButton2Label.LineNumber = 15;
                    _selectStageViewButton2Label.LinePosition = 4;
#endif
                    Delight.Label.FontSizeProperty.SetDefault(_selectStageViewButton2Label, 24);
                    Delight.Label.FontColorProperty.SetDefault(_selectStageViewButton2Label, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontProperty.SetDefault(_selectStageViewButton2Label, Assets.Fonts["Fifaks10Dev1"]);
                    Delight.Label.FontColorProperty.SetStateDefault("Highlighted", _selectStageViewButton2Label, new UnityEngine.Color(1f, 0.8941177f, 0.4705882f, 1f));
                    Delight.Label.FontSizeProperty.SetStateDefault("Highlighted", _selectStageViewButton2Label, 30);
                    Delight.Label.TextProperty.SetDefault(_selectStageViewButton2Label, "<");
                }
                return _selectStageViewButton2Label;
            }
        }

        private static Template _selectStageViewButton3;
        public static Template SelectStageViewButton3
        {
            get
            {
#if UNITY_EDITOR
                if (_selectStageViewButton3 == null || _selectStageViewButton3.CurrentVersion != Template.Version)
#else
                if (_selectStageViewButton3 == null)
#endif
                {
                    _selectStageViewButton3 = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _selectStageViewButton3.Name = "SelectStageViewButton3";
                    _selectStageViewButton3.LineNumber = 13;
                    _selectStageViewButton3.LinePosition = 6;
#endif
                    Delight.Button.BackgroundSpriteProperty.SetDefault(_selectStageViewButton3, Assets.Sprites["Pxiel Art UI borders_0"]);
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Pressed", _selectStageViewButton3, new UnityEngine.Color(0.6901961f, 0.1882353f, 0.3607843f, 1f));
                    Delight.Button.WidthProperty.SetDefault(_selectStageViewButton3, new ElementSize(0.1f, ElementSizeUnit.Percents));
                    Delight.Button.HeightProperty.SetDefault(_selectStageViewButton3, new ElementSize(0.1f, ElementSizeUnit.Percents));
                    Delight.Button.AlignmentProperty.SetDefault(_selectStageViewButton3, Delight.ElementAlignment.Right);
                    Delight.Button.MarginProperty.SetDefault(_selectStageViewButton3, new ElementMargin(new ElementSize(20f, ElementSizeUnit.Pixels), new ElementSize(20f, ElementSizeUnit.Pixels), new ElementSize(50f, ElementSizeUnit.Pixels), new ElementSize(20f, ElementSizeUnit.Pixels)));
                    Delight.Button.IsVisibleProperty.SetHasBinding(_selectStageViewButton3);
                    Delight.Button.LabelTemplateProperty.SetDefault(_selectStageViewButton3, SelectStageViewButton3Label);
                }
                return _selectStageViewButton3;
            }
        }

        private static Template _selectStageViewButton3Label;
        public static Template SelectStageViewButton3Label
        {
            get
            {
#if UNITY_EDITOR
                if (_selectStageViewButton3Label == null || _selectStageViewButton3Label.CurrentVersion != Template.Version)
#else
                if (_selectStageViewButton3Label == null)
#endif
                {
                    _selectStageViewButton3Label = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _selectStageViewButton3Label.Name = "SelectStageViewButton3Label";
                    _selectStageViewButton3Label.LineNumber = 15;
                    _selectStageViewButton3Label.LinePosition = 4;
#endif
                    Delight.Label.FontSizeProperty.SetDefault(_selectStageViewButton3Label, 24);
                    Delight.Label.FontColorProperty.SetDefault(_selectStageViewButton3Label, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontProperty.SetDefault(_selectStageViewButton3Label, Assets.Fonts["Fifaks10Dev1"]);
                    Delight.Label.FontColorProperty.SetStateDefault("Highlighted", _selectStageViewButton3Label, new UnityEngine.Color(1f, 0.8941177f, 0.4705882f, 1f));
                    Delight.Label.FontSizeProperty.SetStateDefault("Highlighted", _selectStageViewButton3Label, 30);
                    Delight.Label.TextProperty.SetDefault(_selectStageViewButton3Label, ">");
                }
                return _selectStageViewButton3Label;
            }
        }

        #endregion
    }

    #endregion
}
