<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="frmMarca.aspx.vb" Inherits="SistemaWeb_Ventas.frmMarca" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- page content -->
    <div class="right_col" role="main">
        <div class="">
            <div class="page-title">
                <div class="title_left">
                    <h3>Formulario de Marca</h3>
                </div>
            </div>

            <div class="clearfix"></div>

            <div class="row">
                <div class="col-md-12 col-sm-12  ">
                    <div class="x_panel">
                        <div class="x_title">
                            <h2>Mantenimiento de Marca</h2>
                            <ul class="nav navbar-right panel_toolbox">
                                <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                                </li>
                            </ul>
                            <div class="clearfix"></div>
                        </div>
                        <div class="x_content">
                            <%--<form class="form-horizontal form-label-left" method="post" action="#" runat="server">--%>
                            <div class="field item form-group">
                                <label class="col-form-label col-md-3 col-sm-3  label-align">
                                    Marca<span
                                        class="required">*</span></label>
                                <div class="col-md-6 col-sm-6">
                                    <asp:TextBox ID="txtMarca" runat="server" CssClass="form-control" TabIndex="1" required="required"></asp:TextBox>
                                </div>
                            </div>
                            <div class="ln_solid">
                                <div class="form-group">
                                    <div class="col-md-6 offset-md-3">
                                        <asp:Button ID="btnNuevo" runat="server" Text="Agregar" TabIndex="2" CssClass="btn btn-primary" />
                                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" TabIndex="3" CssClass="btn btn-danger" />
                                    </div>
                                </div>
                            </div>
                            <%--</form>--%>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12 col-sm-12  ">
                    <div class="x_panel">
                        <div class="x_title">
                            <h2>Listado de marcas</h2>
                            <ul class="nav navbar-right panel_toolbox">
                                <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                                </li>
                            </ul>
                            <div class="clearfix"></div>
                        </div>
                        <div class="x_content">
                            <asp:Button ID="btnShowFormMarca" runat="server" Height="36px" Text="Nueva Marca" TabIndex="4" CssClass="btn btn-primary" />
                            <asp:GridView ID="tblMarca" runat="server" CssClass="table" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False">
                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                <Columns>
                                    <asp:TemplateField HeaderText="ID"></asp:TemplateField>
                                    <asp:TemplateField HeaderText="Marca"></asp:TemplateField>
                                    <asp:CommandField ButtonType="Button" HeaderText="Opciones" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" ControlStyle-CssClass="btn-info" />
                                </Columns>                                
                                <HeaderStyle BackColor="Black" CssClass="thead-dark" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#383838" />
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- /page content -->
</asp:Content>
