﻿// <copyright>
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
// import { defineComponent, PropType } from "vue";

export type ItemWithPreAndPostHtml = {
    slotName: string;
    preHtml: string;
    postHtml: string;
};

import { defineComponent, h, PropType, Slots, VNode } from "vue";

export default defineComponent({
    props: {
        items: { type: Array as PropType<ItemWithPreAndPostHtml[]>, default: [] }
    },
    setup: (props, { slots }) => {
        let renderCt: HTMLDivElement;

        // Convert a Node's children into VNodes
        function childrenToVNodes(node: Node, slots: Slots): Array<ReturnType<typeof domToVNodes>> {
            return Array.from(node.childNodes).map(node => domToVNodes(node, slots));
        }

        // Convert a Node into VNode
        function domToVNodes(domNode: Node, slots: Slots): VNode | string | Array<VNode | string | VNode[]> {
            const attributes = {};
            let children: ReturnType<typeof childrenToVNodes>;
            let text: string;
            let el: Element;
            let textNode: Text;

            switch (domNode.nodeType) {
                case 1:
                    // Element: convert to VNode
                    el = domNode as Element;
                    for (const { name, value } of el.attributes) {
                        // Use ^ to force them to be used as attributes
                        attributes[`^${name}`] = value;
                    }

                    children = childrenToVNodes(el, slots);

                    return h(el.tagName.toLowerCase(), attributes, children);
                case 3:
                    // Text: convert to string, and/or replace the placeholder text with slot content
                    textNode = domNode as Text;
                    text = textNode.data;

                    // Find placeholders
                    if (/%%%:::[a-zA-Z0-9-_]+:::%%%/.test(text)) {
                        // Split other text out away from placeholders
                        const parts = text.split("%%%");

                        // Find the pieces that are placeholders and convert them to slot content or return other text
                        return parts.map(txt => {
                            if (/:::[a-zA-Z0-9-_]+:::/.test(txt)) {
                                const matches = txt.match(/[a-zA-Z0-9-_]+/);
                                if (matches && matches.length > 0) {
                                    const [slotName] = matches;
                                    return slots[slotName]?.() ?? slotName;
                                }
                                return txt;
                            }

                            return txt;
                        });
                    }

                    return textNode.data;
            }

            return "";
        }

        // Render Function
        return () => {
            const html = props.items.map(({ slotName, preHtml, postHtml }) => {
                return `${preHtml}%%%:::${slotName}:::%%%${postHtml}`;
            }).join("");

            if (!renderCt) {
                renderCt = document.createElement("div");
            }

            renderCt.innerHTML = html;

            return childrenToVNodes(renderCt, slots);
        };
    }
});
