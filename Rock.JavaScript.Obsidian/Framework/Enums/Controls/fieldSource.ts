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

/**
 * The source of the data for the field. The two types are properties on the item model and an attribute expression.
 * This is copied to Rock/Mobile/JsonFields/FieldSource.cs. If any changes are made here,
 * they may need to be copied there as well.
 */
export const FieldSource = {
    /** The source comes from a model property. */
    Property: 0,

    /** The source comes from an attribute defined on the model. */
    Attribute: 1,

    /** The source comes from a custom lava expression. */
    LavaExpression: 2
} as const;

/**
 * The source of the data for the field. The two types are properties on the item model and an attribute expression.
 * This is copied to Rock/Mobile/JsonFields/FieldSource.cs. If any changes are made here,
 * they may need to be copied there as well.
 */
export const FieldSourceDescription: Record<number, string> = {
    0: "Property",

    1: "Attribute",

    2: "Lava Expression"
};

/**
 * The source of the data for the field. The two types are properties on the item model and an attribute expression.
 * This is copied to Rock/Mobile/JsonFields/FieldSource.cs. If any changes are made here,
 * they may need to be copied there as well.
 */
export type FieldSource = typeof FieldSource[keyof typeof FieldSource];
