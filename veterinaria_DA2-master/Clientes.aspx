<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Clientes.aspx.cs" Inherits="Clientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" BackColor="Yellow" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" Text="MANTENIMIENTO DE CLIENTES"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="DNI:"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Nombre :"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="nombre de mascota:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="EDAD de Mascota:"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" ></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Label" Width="500px"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="INSERTAR" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="ACTUALIZAR" />
        <br />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="ELIMINAR" />
        <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="BUSCAR" />
        <br />
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" onclick="Button5_Click" Text="MOSTRAR TODO LOS Clientes" />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
    </p>
    <p>
        <br />
        <br />
        <br />
        <br />
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

