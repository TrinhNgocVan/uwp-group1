#pragma checksum "E:\uwp-group1\Pages\Category.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C75768EDBA4C4C22F80C150457F8711A66B1DAED78C30F3C5D2F3A6EA65A4F14"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nhom1.Pages
{
    partial class EatIn : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_FrameworkElement_Tag(global::Windows.UI.Xaml.FrameworkElement obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Tag = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class EatIn_obj9_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IEatIn_Bindings
        {
            private global::Nhom1.Models.Food dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj9;
            private global::Windows.UI.Xaml.Controls.TextBlock obj10;
            private global::Windows.UI.Xaml.Controls.Image obj11;
            private global::Windows.UI.Xaml.Controls.TextBlock obj12;
            private global::Windows.UI.Xaml.Controls.TextBlock obj14;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj9TagDisabled = false;
            private static bool isobj10TextDisabled = false;
            private static bool isobj11SourceDisabled = false;
            private static bool isobj12TextDisabled = false;
            private static bool isobj14TextDisabled = false;

            public EatIn_obj9_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 63 && columnNumber == 127)
                {
                    isobj9TagDisabled = true;
                }
                else if (lineNumber == 65 && columnNumber == 84)
                {
                    isobj10TextDisabled = true;
                }
                else if (lineNumber == 66 && columnNumber == 81)
                {
                    isobj11SourceDisabled = true;
                }
                else if (lineNumber == 67 && columnNumber == 145)
                {
                    isobj12TextDisabled = true;
                }
                else if (lineNumber == 70 && columnNumber == 61)
                {
                    isobj14TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 9: // Pages\Category.xaml line 63
                        this.obj9 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.GridViewItem)target);
                        break;
                    case 10: // Pages\Category.xaml line 65
                        this.obj10 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 11: // Pages\Category.xaml line 66
                        this.obj11 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 12: // Pages\Category.xaml line 67
                        this.obj12 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 14: // Pages\Category.xaml line 69
                        this.obj14 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj9.Target as global::Windows.UI.Xaml.Controls.GridViewItem).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::Nhom1.Models.Food) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // IEatIn_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Nhom1.Models.Food)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Nhom1.Models.Food obj, int phase)
            {
                EatIn_obj9_Bindings bindings = this;
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_id(obj.id, phase);
                        this.Update_image(obj.image, phase);
                        this.Update_price(obj.price, phase);
                        this.Update_name(obj.name, phase);
                    }
                }
            }
            private void Update_id(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\Category.xaml line 63
                    if (!isobj9TagDisabled)
                    {
                        if ((this.obj9.Target as global::Windows.UI.Xaml.Controls.GridViewItem) != null)
                        {
                            XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Tag((this.obj9.Target as global::Windows.UI.Xaml.Controls.GridViewItem), obj, null);
                        }
                    }
                    // Pages\Category.xaml line 65
                    if (!isobj10TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj10, obj.ToString(), null);
                    }
                }
            }
            private void Update_image(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\Category.xaml line 66
                    if (!isobj11SourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj11, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                    }
                }
            }
            private void Update_price(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\Category.xaml line 67
                    if (!isobj12TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj12, obj.ToString(), null);
                    }
                }
            }
            private void Update_name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\Category.xaml line 69
                    if (!isobj14TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj14, obj, null);
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class EatIn_obj4_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IEatIn_Bindings
        {
            private global::Nhom1.Models.CategoryData dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj4;
            private global::Windows.UI.Xaml.Controls.Image obj5;
            private global::Windows.UI.Xaml.Controls.TextBlock obj6;
            private global::Windows.UI.Xaml.Controls.GridView obj7;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj5SourceDisabled = false;
            private static bool isobj6TextDisabled = false;
            private static bool isobj7ItemsSourceDisabled = false;

            public EatIn_obj4_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 55 && columnNumber == 61)
                {
                    isobj5SourceDisabled = true;
                }
                else if (lineNumber == 56 && columnNumber == 99)
                {
                    isobj6TextDisabled = true;
                }
                else if (lineNumber == 58 && columnNumber == 98)
                {
                    isobj7ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4: // Pages\Category.xaml line 51
                        this.obj4 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.ListViewItem)target);
                        break;
                    case 5: // Pages\Category.xaml line 55
                        this.obj5 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 6: // Pages\Category.xaml line 56
                        this.obj6 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 7: // Pages\Category.xaml line 58
                        this.obj7 = (global::Windows.UI.Xaml.Controls.GridView)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj4.Target as global::Windows.UI.Xaml.Controls.ListViewItem).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::Nhom1.Models.CategoryData) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // IEatIn_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Nhom1.Models.CategoryData)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Nhom1.Models.CategoryData obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_category(obj.category, phase);
                        this.Update_foods(obj.foods, phase);
                    }
                }
            }
            private void Update_category(global::Nhom1.Models.Category obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_category_icon(obj.icon, phase);
                        this.Update_category_name(obj.name, phase);
                    }
                }
            }
            private void Update_category_icon(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\Category.xaml line 55
                    if (!isobj5SourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj5, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                    }
                }
            }
            private void Update_category_name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\Category.xaml line 56
                    if (!isobj6TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj6, obj, null);
                    }
                }
            }
            private void Update_foods(global::System.Collections.Generic.List<global::Nhom1.Models.Food> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\Category.xaml line 58
                    if (!isobj7ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj7, obj, null);
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Pages\Category.xaml line 48
                {
                    this.MNItems = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 9: // Pages\Category.xaml line 63
                {
                    global::Windows.UI.Xaml.Controls.GridViewItem element9 = (global::Windows.UI.Xaml.Controls.GridViewItem)(target);
                    ((global::Windows.UI.Xaml.Controls.GridViewItem)element9).Tapped += this.ListViewItem_Tapped;
                }
                break;
            case 15: // Pages\Category.xaml line 13
                {
                    this.header = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 16: // Pages\Category.xaml line 15
                {
                    this.logo1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 17: // Pages\Category.xaml line 16
                {
                    this.ResName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18: // Pages\Category.xaml line 18
                {
                    this.Head = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19: // Pages\Category.xaml line 19
                {
                    this.FacebookButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 20: // Pages\Category.xaml line 24
                {
                    this.FacebookButton_Copy = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 21: // Pages\Category.xaml line 29
                {
                    this.FacebookButton_Copy1 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 22: // Pages\Category.xaml line 34
                {
                    this.FacebookButton_Copy2 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 23: // Pages\Category.xaml line 39
                {
                    this.FacebookButton_Copy3 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 24: // Pages\Category.xaml line 40
                {
                    this.FacebookButton_Copy4 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 4: // Pages\Category.xaml line 51
                {                    
                    global::Windows.UI.Xaml.Controls.ListViewItem element4 = (global::Windows.UI.Xaml.Controls.ListViewItem)target;
                    EatIn_obj4_Bindings bindings = new EatIn_obj4_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element4.DataContext);
                    element4.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element4, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element4, bindings);
                }
                break;
            case 9: // Pages\Category.xaml line 63
                {                    
                    global::Windows.UI.Xaml.Controls.GridViewItem element9 = (global::Windows.UI.Xaml.Controls.GridViewItem)target;
                    EatIn_obj9_Bindings bindings = new EatIn_obj9_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element9.DataContext);
                    element9.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element9, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element9, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

