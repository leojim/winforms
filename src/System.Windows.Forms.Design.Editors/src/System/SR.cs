﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

///------------------------------------------------------------------------------

using System.Resources;

namespace System.Windows.Forms.Design.Editors.System
{
    internal static class SR
    {
        private static global::System.Resources.ResourceManager s_resourceManager;
        internal static global::System.Resources.ResourceManager ResourceManager => s_resourceManager ?? (s_resourceManager = new global::System.Resources.ResourceManager(typeof(SR)));

        internal static global::System.Globalization.CultureInfo Culture { get; set; }

        internal static string GetResourceString(string resourceKey, string defaultValue = null) => ResourceManager.GetString(resourceKey, Culture);

        internal static string RTL => GetResourceString("RTL");

        internal static string CollectionEditorCantRemoveItem = GetResourceString("CollectionEditorCantRemoveItem");

        internal static string CollectionEditorCaption = GetResourceString("CollectionEditorCaption");

        internal static string CollectionEditorInheritedReadOnlySelection = GetResourceString("CollectionEditorInheritedReadOnlySelection");
        
        internal static string CollectionEditorProperties = GetResourceString("CollectionEditorProperties");

        internal static string CollectionEditorPropertiesMultiSelect = GetResourceString("CollectionEditorPropertiesMultiSelect");

        internal static string CollectionEditorPropertiesNone = GetResourceString("CollectionEditorPropertiesNone");

        internal static string CollectionEditorUndoBatchDesc = GetResourceString("CollectionEditorUndoBatchDesc");
    }
}