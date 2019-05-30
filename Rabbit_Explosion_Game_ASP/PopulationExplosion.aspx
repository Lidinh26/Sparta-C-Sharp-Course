<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PopulationExplosion.aspx.cs" Inherits="Rabbit_Explosion_Game_ASP.PopulationExplosion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Population Explosion</h1>

    <h2>Please enter the desired maxinum population ceiling</h2>

    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

    <hr/>

    <asp:Label ID="Label1" runat="server" Text="Results:"></asp:Label>
    
       <br />
    <hr />
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
    <hr />  
</asp:Content>
