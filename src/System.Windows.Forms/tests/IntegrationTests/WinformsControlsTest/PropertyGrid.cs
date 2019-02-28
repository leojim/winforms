﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.Collections.Generic;
using System;
using System.Globalization;
using System.Text;

namespace WinformsControlsTest
{
    public partial class PropertyGrid : Form
    {
        public PropertyGrid()
        {
            InitializeComponent();
            propertyGrid1.SelectedObject = new UserControlWithObjectCollectionEditor();
        }
    }

    internal class UserControlWithObjectCollectionEditor : UserControl
    {
        public UserControlWithObjectCollectionEditor()
        {
            AutoScaleMode = AutoScaleMode.Font;
        }

        [Editor(typeof(CollectionEditor), typeof(UITypeEditor))]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [TypeConverter(typeof(SomeCollectionTypeConverter))]
        public IList<int> SomeCollection
        {
            get { return new List<int>(new int[] { 1, 2, 3 }); }
            set { }
        }
    }

    internal class SomeCollectionTypeConverter : TypeConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType != null && destinationType.IsAssignableFrom(typeof(string)) && value != null && value is IList<int> list)
            {
                var result = new StringBuilder("");
                for (int i = 0; i < list.Count; i++)
                {
                    if (i != 0)
                    {
                        result.Append(", ");
                    }
                    result.Append(list[i]);
                }
                return result.ToString();
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }

}
