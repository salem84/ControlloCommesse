<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Resoconto.aspx.cs" Inherits="ControlloCommesseWeb.Pages.Resoconto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div>
            
            <asp:Panel runat="server" ID="pnlResoconto" Visible="false">
                <h3>Resoconto Attività</h3>
                <asp:GridView runat="server" ID="gridResoconto" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="Titolo" HeaderText="Commessa" HeaderStyle-Width="100"/>
                        <asp:TemplateField HeaderText="Ore">
                            <ItemTemplate><asp:Label runat="server" ID="lblOre" Text='<%# DisplayAsHoursMinutes(Eval("Totale")) %>'></asp:Label></ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="NumeroAttivita" HeaderText="Numero" />
                    </Columns>
                </asp:GridView>

            </asp:Panel>
        </div>
</asp:Content>
