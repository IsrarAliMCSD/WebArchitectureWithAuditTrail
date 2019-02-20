<%@ Page Title="" Language="C#" MasterPageFile="~/Master/App_Master.Master" AutoEventWireup="true" CodeBehind="Test1.aspx.cs" Inherits="WebApp_Amjad.Form.Test1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-1">
            <asp:Label ID="lblEventDetailId" Visible="false" runat="server" Text=""></asp:Label>
            <asp:Label ID="lblEventType" runat="server" CssClass="label" Text="Event Types:"></asp:Label>
        </div>
        <div class="col-3">
            <asp:DropDownList ID="ddlEventType" CssClass="ddlWidth100 ddl" runat="server"></asp:DropDownList>
            <asp:RequiredFieldValidator InitialValue="-1" ID="rfveventType" Display="Dynamic" CssClass="validation"
                ValidationGroup="eventDetail" runat="server" ControlToValidate="ddlEventType"
                ErrorMessage="Please select event type"></asp:RequiredFieldValidator>
        </div>
        <div class="col-4">
        </div>
        <div class="col-1">
            <asp:Label ID="Label1" runat="server" CssClass="label" Text="Issue Med:"></asp:Label>
        </div>
        <div class="col-3">
            <asp:DropDownList ID="ddlIssueMedium" CssClass="ddlWidth100 ddl" runat="server"></asp:DropDownList>
            <asp:RequiredFieldValidator InitialValue="-1" ID="RequiredFieldValidator1" Display="Dynamic" CssClass="validation"
                ValidationGroup="eventDetail" runat="server" ControlToValidate="ddlIssueMedium"
                ErrorMessage="Please select issue medium"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-1">
            <asp:Label ID="Label2" runat="server" CssClass="label" Text="LC Number:"></asp:Label>
        </div>
        <div class="col-3">
            <asp:TextBox ID="txtLCNumber" runat="server" CssClass="textBox"></asp:TextBox>
            <asp:ImageButton ID="ibtnLCFind" runat="server" ImageUrl="~/Images/download.png" Width="25px" Height="25px" OnClick="ibtnLCFind_Click" />
        </div>
        <div class="col-1">
            <asp:Label ID="Label3" runat="server" CssClass="label" Text="Event No:"></asp:Label>
        </div>
        <div class="col-3">
            <asp:TextBox ID="txtEventNo" runat="server" CssClass="textBox"></asp:TextBox>
        </div>
        <div class="col-1">
            <asp:Label ID="Label4" runat="server" CssClass="label" Text="Status/Event:"></asp:Label>
        </div>
        <div class="col-3">
            <asp:TextBox ID="txtEventStatus1" runat="server" CssClass="width100 textBox100W width100"></asp:TextBox>
            <asp:TextBox ID="txtEventStatus2" runat="server" CssClass="width100 textBox100W width100"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-1">
            <asp:Label ID="Label5" runat="server" CssClass="label" Text="Corresp No:"></asp:Label>
        </div>
        <div class="col-3">
            <asp:TextBox ID="txtCorrespondanceNo" runat="server" CssClass="textBox"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-1">
            <asp:Label ID="Label6" runat="server" CssClass="label" Text="Crsp Date:"></asp:Label>
        </div>
        <div class="col-3">
            <asp:TextBox ID="txtCorrespondanceDate" runat="server" CssClass="calendar textBox "></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-1">
            <asp:Label ID="Label7" runat="server" CssClass="label" Text="Crsp Type:"></asp:Label>
        </div>
        <div class="col-3">
            <asp:DropDownList ID="ddlCorrespondanceType" CssClass="ddlWidth100 ddl" runat="server"></asp:DropDownList>
            <asp:RequiredFieldValidator InitialValue="-1" ID="RequiredFieldValidator2" Display="Dynamic" CssClass="validation"
                ValidationGroup="eventDetail" runat="server" ControlToValidate="ddlCorrespondanceType"
                ErrorMessage="Please select correspondance type"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-1">
            <asp:Label ID="Label8" runat="server" CssClass="label" Text="Parties:"></asp:Label>
        </div>
        <div class="col-3">
            <asp:DropDownList ID="ddlParties" CssClass="ddlWidth100 ddl" runat="server"></asp:DropDownList>
            <asp:RequiredFieldValidator InitialValue="-1" ID="RequiredFieldValidator3" Display="Dynamic" CssClass="validation"
                ValidationGroup="eventDetail" runat="server" ControlToValidate="ddlParties"
                ErrorMessage="Please select Parties"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-1"></div>
        <div class="col-11">
            <asp:RadioButtonList ID="rbtlBankBranch" runat="server" TextAlign="Right" CssClass="label" RepeatDirection="Horizontal">
                <asp:ListItem Text="Bank" Value="BANK"></asp:ListItem>
                <asp:ListItem Text="Branch" Value="BRANCH"></asp:ListItem>
            </asp:RadioButtonList>
        </div>
    </div>

    <div class="row">
        <div class="col-1">
            <asp:Label ID="Label9" runat="server" CssClass="label" Text="Infrmation:"></asp:Label>
        </div>
        <div class="col-4">
            <asp:TextBox ID="txtinformation1" runat="server" TextMode="MultiLine" Rows="5" Columns="50" CssClass="    "></asp:TextBox>
        </div>
        <div class="col-3">
        </div>
        <div class="col-4">
            <asp:TextBox ID="txtinformationMain" runat="server" TextMode="MultiLine" Rows="5" Columns="50" CssClass="    "></asp:TextBox>
        </div>

    </div>

    <div class="row">
        <div class="col-1">
        </div>
        <div class="col-5">
            <asp:TextBox ID="txtinformation2" runat="server" CssClass="textBox "></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-1">
            <asp:Label ID="Label10" runat="server" CssClass="label" Text="Reference:"></asp:Label>
        </div>
        <div class="col-5">
            <asp:TextBox ID="txtReference" runat="server" CssClass="textBox "></asp:TextBox>
        </div>
    </div>

    <div class="row">
        <div class="col-1">
            <asp:Label ID="Label11" runat="server" CssClass="label" Text="Intraction To Send:"></asp:Label>
        </div>
        <div class="col-5">
            <asp:TextBox ID="txtIntractionToSend" runat="server" TextMode="MultiLine" Rows="5" Columns="50" CssClass="    "></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-12">
            <hr />
        </div>
    </div>
    <div class="row">
        <div class="col-12">
            <asp:Label ID="lblError" runat="server" CssClass="validation" Text=""></asp:Label>
        </div>
    </div>
    <div class="row">

        <div class="col-12">
            <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="button width130 height35" ValidationGroup="eventDetail" OnClick="btnAdd_Click" />

            <asp:Button ID="btnApprove" runat="server" Text="Approve" CssClass="button width130 height35" ValidationGroup="eventDetail" OnClick="btnApprove_Click" />

            <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="button width130 height35" ValidationGroup="eventDetail" OnClick="btnDelete_Click" />

            <asp:Button ID="btnPreview" runat="server" Text="Preview" CssClass="button width130 height35" ValidationGroup="eventDetail" OnClick="btnPreview_Click" />

            <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="button width130 height35" ValidationGroup="eventDetail" OnClick="btnSave_Click" />

            <asp:Button ID="btnIgnore" runat="server" Text="Ignore" CssClass="button width130 height35" OnClick="btnIgnore_Click" />

            <asp:Button ID="btnVerify" runat="server" Text="Verify" CssClass="button width130 height35" ValidationGroup="eventDetail" OnClick="btnVerify_Click" />

            <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="button width130 height35" OnClick="btnCancel_Click" />
        </div>
    </div>

</asp:Content>
