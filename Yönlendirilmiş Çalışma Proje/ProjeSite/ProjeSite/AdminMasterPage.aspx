<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AdminMasterPage.aspx.cs" Inherits="ProjeSite.AdminMasterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <head>
        <link href="Content/css/bootstrap.min.css" rel="stylesheet" />

    </head>
<style>
tr:nth-of-type(odd) { 
    background: #eee; 
    }

th { 
    background: #3498db; 
    color: white; 
    font-weight: bold; 
    }

td, th { 
    padding: 10px; 
    border: 1px solid #ccc; 
    text-align: left; 
    font-size: 18px;
    }

/* 
Max width before this PARTICULAR table gets nasty
This query will take effect for any screen smaller than 760px
and also iPads specifically.
*/
@media 
only screen and (max-width: 760px),
(min-device-width: 768px) and (max-device-width: 1024px)  {

    table { 
        width: 100%; 
    }

    /* Force table to not be like tables anymore */
    table, thead, tbody, th, td, tr { 
        display: block; 
    }
    
    /* Hide table headers (but not display: none;, for accessibility) */
    thead tr { 
        position: absolute;
        top: -9999px;
        left: -9999px;
    }
    
    tr { border: 1px solid #ccc; }
    
    td { 
        /* Behave  like a "row" */
        border: none;
        border-bottom: 1px solid #eee; 
        position: relative;
        padding-left: 50%; 
    }

    td:before { 
        /* Now like a table header */
        position: absolute;
        /* Top/left values mimic padding */
        top: 6px;
        left: 6px;
        width: 45%; 
        padding-right: 10px; 
        white-space: nowrap;
        /* Label the data */
        content: attr(data-column);

        color: #000;
        font-weight: bold;
    }

}
</style>

<%--    --------------------------------------%>
    <h2>ÜYELERİM</h2>
<table>
  <thead>
    <tr>
     <th scope="col" >İD</th>
                <th scope="col">AD</th>              
              <th scope="col">SOYAD</th>
              <th scope="col">DG.TRH</th>
                <th scope="col">ÜYELİK.S.BS</th>
                 <th scope="col">ÜYELİK.S.BTS</th>
              <th scope="col">ÜYELİK.KLN.SR</th>
                <th scope="col">E_MAİL</th>
                <th scope="col">TELEFON_NO</th>
               <th scope="col">DUZENLE</th>
    </tr>
  </thead>
  <tbody>
      <asp:Repeater ID="üyeListeİd" runat="server">
                  <ItemTemplate>
    <tr>
      <td data-column="İD"> <%#Eval("id") %></td>
      <td data-column="AD"> <%#Eval("Ad") %></td>
      <td data-column="SOYAD"> <%#Eval("Soyad") %></td>
      <td data-column="DG.TRH"> <%#Eval("Dogum_Tarihi") %></td>
        <td data-column="ÜYELİK.S.BS"> <%#Eval("Uyelik_Suresibaslangic") %></td>
         <td data-column="ÜYELİK.S.BTS"> <%#Eval("Uyelik_Suresibitis") %></td>
        <td data-column="ÜYELİK.KLN.SR"> <%#Eval("Uyelik_Kalansüre") %></td>
        <td data-column="E_MAİL"> <%#Eval("E_mail") %></td>
        <td data-column="TELEFON_NO"> <%#Eval("Telefon_No") %> </td>
        <td data-column="DÜZENLE"> <%#Eval("id") %></td>
    </tr>
        </ItemTemplate>
              </asp:Repeater>
  </tbody>
</table>
</div>
</asp:Content>
