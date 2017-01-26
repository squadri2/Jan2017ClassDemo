﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RepeaterNestedRepeater.aspx.cs" Inherits="SamplePages_RepeaterNestedRepeater" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">


    <br /><br />

    <%--repeater and EVAL in the strong --%>

<%--    outer repeater will display Flat fields from the DTO class, 
    outer repeater gets its datasource from the ODS Control (DatasourceID)



    the inner repeater will display flat fields from the POCO class
    inner repeater gets its data scourse from the LIST <T> feild of the DTO class (Datasource)
    
    
    Use of the ItemType parameter on the repeater allows you to use 
    object instance referencing(instance.property) for fields instead of Eval("xxx")
    referencing     
    --%>
        
    <div class=" col-sm-6">
    <asp:Repeater ID="ArtistAlbumReleasesList" runat="server" DataSourceID="ArtistAlbumReleasesODS">



        <HeaderTemplate>
            <h3>Albums Releases for Artists</h3>
        </HeaderTemplate>

        <ItemTemplate>
            <strong><%#Eval("Artist")%></strong><br />
            <asp:Repeater ID="Albums" runat="server"
                DataSource=' <%# Eval("Albums") %>'>
                <HeaderTemplate>
                    <table>
                        <tr>
                            <th>Year</th>
                            <th>Label</th>
                            <th>Title</th>
                        </tr>
                    

                </HeaderTemplate>

                <ItemTemplate>
                    <tr>
                            <td><%# Eval("Ryear") %></td>
                            <td><%# Eval("Label") %></td>
                            <td><%# Eval("Title") %></td>
                        </tr>
                </ItemTemplate>

                

                <FooterTemplate>
                  

                    </table><br />
                </FooterTemplate>

            </asp:Repeater>
        </ItemTemplate>

    </asp:Repeater>
</div>



     <div class=" col-sm-6">
    <asp:Repeater ID="ArtistAlbumReleasesB" runat="server" DataSourceID="ArtistAlbumReleasesODS"
        ItemType="Chinook.Data.DTOs.ArtistAlbumRelease">



        <HeaderTemplate>
            <h3>Albums Releases for Artists</h3>
        </HeaderTemplate>

        <ItemTemplate>
            <strong><%# Item.Artist %></strong><br />
            <asp:Repeater ID="Albums" runat="server"
                DataSource=' <%# Item.Albums %>'
                ItemType="Chinook.Data.POCOs.AlbumRelease">
                <HeaderTemplate>
                    <table>
                        <tr>
                            <th>Year</th>
                            <th>Label</th>
                            <th>Title</th>
                        </tr>
                    

                </HeaderTemplate>

                <ItemTemplate>
                    <tr>
                            <td><%# Item.Ryear %></td>
                            <td><%# Item.Label %></td>
                            <td><%# Item.Title %></td>
                        </tr>
                </ItemTemplate>

                

                <FooterTemplate>
                    </table><br />
                </FooterTemplate>

            </asp:Repeater>
        </ItemTemplate>

    </asp:Repeater>
</div>
    <asp:ObjectDataSource ID="ArtistAlbumReleasesODS" runat="server" 
        OldValuesParameterFormatString="original_{0}" 
        SelectMethod="ArtistAlbumRelease_List" 
        TypeName="ChinookSystem.BLL.AlbumController"></asp:ObjectDataSource>
    



</asp:Content>

