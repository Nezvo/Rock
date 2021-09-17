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

export const enum GroupRole {
    /** Gets the adult family member role */
    GrouproleFamilyMemberAdult = "2639F9A5-2AAE-4E48-A8C3-4FFE86681E42",
    /** Gets the child family member role */
    GrouproleFamilyMemberChild = "C8B1814F-6AA7-4055-B2D7-48FE20429CB9",
    /** Gets the Known Relationships owner role. */
    GrouproleKnownRelationshipsOwner = "7BC6C12E-0CD1-4DFD-8D5B-1B35AE714C42",
    /** A person that can be checked in by the owner of this known relationship group */
    GrouproleKnownRelationshipsCanCheckIn = "DC8E5C35-F37C-4B49-A5C6-DF3D94FC808F",
    /** A person that can check in the owner of this known relationship group */
    GrouproleKnownRelationshipsAllowCheckInBy = "FF9869F1-BC56-4410-8A12-CAFC32C62257",
    /** A grandparent of the owner of this known relationship group */
    GrouproleKnownRelationshipsGrandparent = "567DA89F-3C43-443D-A988-C05BC516EF28",
    /** A grandchild of the owner of this known relationship group */
    GrouproleKnownRelationshipsGrandchild = "C1A393B2-519D-4E46-A551-E48C36BCAC06",
    /** A brother or sister of the owner of this known relationship group */
    GrouproleKnownRelationshipsSibling = "1D92F0E1-E161-4160-9C63-2D0A901D3C38",
    /** A person that was first invited by the owner of this known relationship group */
    GrouproleKnownRelationshipsInvited = "32E71DAC-B40E-467A-98C9-0AA92AA5025E",
    /** The person that first invited the owner of this known relationship group */
    GrouproleKnownRelationshipsInvitedBy = "03BE336C-CD3D-445C-86EC-0856A51DC926",
    /** A step child of the owner of this known relationship group */
    GrouproleKnownRelationshipsStepChild = "EFD2D6D1-A407-4EFB-9086-5DF1F19B7D93",
    /** A step parent of the owner of this known relationship group */
    GrouproleKnownRelationshipsStepParent = "D14827EF-5D43-442D-8134-DEB58AAC93C5",
    /** An adult child of the owner of this known relationship group */
    GrouproleKnownRelationshipsChild = "F87DF00F-E86D-4771-A3AE-DBF79B78CF5D",
    /** The parent of the owner of this known relationship group */
    GrouproleKnownRelationshipsParent = "6F3FADC4-6320-4B54-9CF6-02EF9586A660",
    /** Role to identify former spouses after divorce. */
    GrouproleKnownRelationshipsPreviousSpouse = "60C6142E-8E00-4678-BC2F-983BB7BDE80B",
    /** Role to identify facebook friends */
    GrouproleKnownRelationshipsFacebookFriend = "AB69816C-4DFA-4A7A-86A5-9BFCBA6FED1E",
    /** Role to identify contacts related to a business. */
    GrouproleKnownRelationshipsBusinessContact = "102E6AF5-62C2-4767-B473-C9C228D75FB6",
    /** A role to identify the business a person owns. */
    GrouproleKnownRelationshipsBusiness = "7FC58BB2-7C1E-4C5C-B2B3-4738258A0BE0",
    /** Gets the Implied Relationships owner role. */
    GrouproleImpliedRelationshipsOwner = "CB9A0E14-6FCF-4C07-A49A-D7873F45E196",
    /** Gets the Peer Network owner role. */
    GrouprolePeerNetworkOwner = "CB9A0E14-6FCF-4C07-A49A-D7873F45E196",
    /** Gets the Implied Relationships related role. */
    GrouproleImpliedRelationshipsRelated = "FEA75948-97CB-4DE9-8A0D-43FA2646F55B",
    /** Gets the Peer Network related role. */
    GrouprolePeerNetworkRelated = "FEA75948-97CB-4DE9-8A0D-43FA2646F55B",
    /** Gets the security group member role. */
    GrouproleSecurityGroupMember = "00F3AC1C-71B9-4EE5-A30E-4C48C8A0BF1F",
    /** Gets the Leader group member role for an Organizational Unit */
    GrouproleOrganizationUnitLeader = "8438D6C5-DB92-4C99-947B-60E9100F223D",
    /** Gets the Staff group member role for an Organizational Unit */
    GrouproleOrganizationUnitStaff = "17E516FC-76A4-4BF4-9B6F-0F859B13F563",
    /** The Leader group member roles for Fundraising Opportunity */
    GrouproleFundraisingopportunityLeader = "253973A5-18F2-49B6-B2F1-F8F84294AAB2",
    /** The Participant group member roles for Fundraising Opportunity */
    GrouproleFundraisingopportunityParticipant = "F82DF077-9664-4DA8-A3D9-7379B690124D",
    /** The Administrator group member role for a Campus Team */
    GrouproleCampusTeamAdministrator = "07F857ED-C0D7-47B4-AB6C-9AFDFAE2ADD9",
    /** The Pastor group member role for a Campus Team */
    GrouproleCampusTeamPastor = "F8C6289B-0E68-4121-A595-A51369404EBA",
}

