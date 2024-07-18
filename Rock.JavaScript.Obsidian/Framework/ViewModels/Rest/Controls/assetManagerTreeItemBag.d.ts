//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//

import { TreeItemBag } from "@Obsidian/ViewModels/Utility/treeItemBag";

/** A TreeItemBag that is extended to give additional information for the AssetManager. */
export type AssetManagerTreeItemBag = {
    /** Gets or sets the child count. Optional. */
    childCount?: number | null;

    /**
     * Gets or sets the children. A value of null indicates that the
     * children should be lazy loaded by the caller.
     */
    children?: TreeItemBag[] | null;

    /** Gets or sets a value indicating whether this instance has children. */
    hasChildren: boolean;

    /** Gets or sets the icon CSS class. */
    iconCssClass?: string | null;

    /** Gets or sets a value indicating whether this instance is active. */
    isActive: boolean;

    /**
     * Gets or sets a value indicating whether this instance is a folder.
     * A folder is an item that is intended to hold child items. This is
     * a distinction from the Rock.ViewModels.Utility.TreeItemBag.HasChildren property which
     * specifies if this item _currently_ has children or not.
     */
    isFolder: boolean;

    /** Gets or sets the text that should be displayed to identify this item. */
    text?: string | null;

    /**
     * Gets or sets the type of item represented by this instance. There is
     * no pre-defined meaning to this, it is up to the item provider to
     * decide what to do with it.
     */
    type?: string | null;

    /** The unencrypted path to the root directory of the asset. */
    unencryptedRoot?: string | null;

    /** Gets or sets the generic identifier of this item. */
    value?: string | null;
};
