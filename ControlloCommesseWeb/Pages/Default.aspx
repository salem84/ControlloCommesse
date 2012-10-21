<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ControlloCommesseWeb.Pages.Default" MasterPageFile="~/Site.Master" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div>
    <asp:ListView runat="server" ID="lvCommesse" DataKeyNames="Id, Titolo" OnItemCommand="lvCommesse_ItemCommand">
        <LayoutTemplate>
            <div runat="server" id="itemPlaceholder">
            </div>
        </LayoutTemplate>
        <ItemTemplate>
            <asp:LinkButton runat="server" 
                CssClass="commessa-button"
                ID="lnkCommessa" 
                BorderColor="Black"
                BorderWidth="2"
                BackColor='<%# Eval("Colore") %>' 
                Text='<%# Eval("Titolo") %>'>

            </asp:LinkButton>
        </ItemTemplate>
    </asp:ListView>
    </div>
    <br />
    <div>
        <h3>Attivita In corso</h3>
        <asp:FormView runat="server" ID="frmAttivitaCorrente">
            <ItemTemplate>
                <div><b>Commessa: </b><%# Eval("Titolo") %></div>
                <div><b>Ora Inizio: </b><%# ((DateTime)Eval("DataInizio")).ToLocalTime().ToLongTimeString() %></div>
            </ItemTemplate>
        </asp:FormView>
    </div>
</asp:Content>