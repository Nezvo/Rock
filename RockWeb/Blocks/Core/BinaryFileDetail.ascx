﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BinaryFileDetail.ascx.cs" Inherits="RockWeb.Blocks.Core.BinaryFileDetail" %>

<asp:UpdatePanel ID="upBinaryFile" runat="server">
    <ContentTemplate>
        <asp:Panel ID="pnlDetails" runat="server" Visible="false" CssClass="panel panel-block">
            <asp:HiddenField ID="hfBinaryFileId" runat="server" />

            <div class="panel-heading">
                <h1 class="panel-title"><i class="fa fa-file-text-o"></i> <asp:Literal ID="lActionTitle" runat="server" /></h1>
            </div>
            <Rock:PanelDrawer ID="pdAuditDetails" runat="server"></Rock:PanelDrawer>
            <div class="panel-body">

                <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Please correct the following:" CssClass="alert alert-validation"  />
                <Rock:NotificationBox ID="nbEditModeMessage" runat="server" NotificationBoxType="Info" />

                <div class="row">
                    <div class="col-md-6">
                        <Rock:DataTextBox ID="tbName" runat="server" SourceTypeName="Rock.Model.BinaryFile, Rock" PropertyName="FileName" Required="true" />
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-12">
                        <Rock:DataTextBox ID="tbDescription" runat="server" SourceTypeName="Rock.Model.BinaryFile, Rock" PropertyName="Description" TextMode="MultiLine" Rows="3" />
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-6">
                        <Rock:NotificationBox ID="nbWorkflowSuccess" runat="server" Visible="false" />
                        <Rock:FileUploader ID="fsFile" runat="server" Label="Upload New File" ShowDeleteButton="false" />
                        <Rock:DataTextBox ID="tbMimeType" runat="server" SourceTypeName="Rock.Model.BinaryFile, Rock" PropertyName="MimeType" />
                        <Rock:BinaryFileTypePicker ID="ddlBinaryFileType" runat="server" Visible="false" />
                    </div>
                    <div class="col-md-6">
                        <div class="attributes">
                            <Rock:DynamicPlaceHolder ID="phAttributes" runat="server" />
                        </div>
                    </div>
                </div>

                <div class="actions">
                    <asp:LinkButton ID="btnSave" runat="server" data-shortcut-key="s" ToolTip="Alt+s" Text="Save" CssClass="btn btn-primary" OnClick="btnSave_Click" />
                    <asp:LinkButton ID="btnCancel" runat="server" data-shortcut-key="c" ToolTip="Alt+c" Text="Cancel" CssClass="btn btn-link" CausesValidation="false" OnClick="btnCancel_Click" />
                    <div class="pull-right">
                        <asp:LinkButton ID="btnEditLabelContents" runat="server" Text="Edit Label Contents" CssClass="btn btn-default" Visible="false" OnClick="btnEditLabelContents_Click" />
                        <asp:LinkButton ID="btnRerunWorkflow" runat="server" Text="Rerun Workflow" CssClass="btn btn-default" Visible="false" OnClick="btnRerunWorkflow_Click" />
                    </div>
                </div>

            </div>

        </asp:Panel>

    </ContentTemplate>
</asp:UpdatePanel>
