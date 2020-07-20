<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="frmProveedor.aspx.vb" Inherits="SistemaWeb_Ventas.frmProveedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 <!-- page content -->
    <div class="right_col" role="main">
        <div class="">
            <div class="page-title">
                <div class="title_left">
                    <h3>Formulario de Proveedor</h3>
                </div>
            </div>

            <div class="clearfix"></div>
            <div class="row">
                <div class="col-md-12 col-sm-12  ">
                        <div class="clearfix"></div>
                        <div class="x_panel">
                        <div class="x_title">
                            <h2>Mantenimiento de Proveedor</h2>
                            <ul class="nav navbar-right panel_toolbox">
                                <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                                </li>
                            </ul>
                            <div class="clearfix"></div>
                        </div>
                        <div class="x_content">
                            <%--<form class="form-horizontal form-label-left" method="post" action="#" runat="server">--%>
                           <div class="row">
                                <div class="col-md-6">

                            <div class="field item form-group">
                                 <label class="col-form-label col-md-3 col-sm-3  label-align">
                                    Datos<span
                                        class="required">*</span></label>
                                <div class="col-md-6 col-sm-6">
                                    <asp:TextBox ID="txtDatos" runat="server" CssClass="form-control" TabIndex="1" required="required"></asp:TextBox>
                                </div>
                            </div>
                            <div class="field item form-group">
                                <label class="col-form-label col-md-3 col-sm-3  label-align">
                                  R.U.C<span
                                        class="required">*</span></label>
                                <div class="col-md-6 col-sm-6">
                                    <asp:TextBox ID="txtruc" runat="server" CssClass="form-control" TabIndex="2" required="required"></asp:TextBox>
                                </div>
                            </div>
                            <div class="field item form-group">
                                <label class="col-form-label col-md-3 col-sm-3  label-align">
                                    Representante<span class="required">*</span></label>
                                <div class="col-md-6 col-sm-6">
                                    <asp:TextBox ID="txtrepresentante" runat="server" CssClass="form-control" TabIndex="3" required="required"></asp:TextBox>
                                </div>
                            </div>
                            <div class="field item form-group">
                                <label class="col-form-label col-md-3 col-sm-3  label-align">
                                    Telefono<span class="required">*</span></label>
                                <div class="col-md-6 col-sm-6">
                                    <asp:TextBox ID="txttelefono" runat="server" CssClass="form-control" TabIndex="4" required="required"></asp:TextBox>
                                </div>
                            </div>
                            <div class="field item form-group">
                                <label class="col-form-label col-md-3 col-sm-3  label-align">
                                    Direccion<span class="required">*</span></label>
                                <div class="col-md-6 col-sm-6">
                                    <asp:TextBox ID="Textdireccion" runat="server" CssClass="form-control" TabIndex="5" required="required"></asp:TextBox>
                                </div>
                            </div>
                            <div class="field item form-group">
                                <label class="col-form-label col-md-3 col-sm-3  label-align">
                                    E-mail<span class="required">*</span></label>
                                <div class="col-md-6 col-sm-6">
                                    <asp:TextBox ID="Textemail" runat="server" CssClass="form-control" TabIndex="6" required="required"></asp:TextBox>
                                </div>
                            </div>
                             <div class="field item form-group">
                                <label class="col-form-label col-md-3 col-sm-3  label-align">
                                    Estado<span class="required">*</span></label>
                                <div class="col-md-6 col-sm-6">
                                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" TabIndex="7">
                                        <asp:ListItem>Seleccionar estado:</asp:ListItem>
                                        <asp:ListItem Value="A">Activo</asp:ListItem>
                                        <asp:ListItem Value="I">Inactivo</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="ln_solid">
                                <div class="form-group">
                                    <div class="col-md-6 offset-md-3">
                                        <asp:Button ID="btnNuevo" runat="server" Text="Agregar" TabIndex="10" CssClass="btn btn-primary" />
                                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" TabIndex="11" CssClass="btn btn-danger" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12 col-sm-12  ">
                    <div class="x_panel">
                        <div class="x_title">
                            <h2>Listado de Proveedores</h2>
                            <ul class="nav navbar-right panel_toolbox">
                                <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                                </li>
                            </ul>
                            <div class="clearfix"></div>
                        </div>
                        <div class="x_content">
                            <asp:Button ID="btnShowFormCli" runat="server" Height="36px" Text="Nuevo Cliente" TabIndex="7" CssClass="btn btn-primary" /><br />
                            <asp:GridView ID="tblCliente" runat="server" CssClass="table" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" ShowHeaderWhenEmpty="True">
                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                <Columns>






                                    <%--<asp:TemplateField HeaderText="ID">
                                        <ItemTemplate>
                                            <asp:Label ID="lblID" runat="server" Text='<% # Eval("ID_CLIENTE")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Datos"></asp:TemplateField>
                                    <asp:TemplateField HeaderText="RUC"></asp:TemplateField>
                                    <asp:TemplateField HeaderText="Representante"></asp:TemplateField>
                                    <asp:TemplateField HeaderText="Telefono"></asp:TemplateField>
                                    <asp:TemplateField HeaderText="Dirección"></asp:TemplateField>
                                    <asp:TemplateField HeaderText="E-mail"></asp:TemplateField>--%>
                                    
                                    <asp:CommandField ButtonType="Button" HeaderText="Opciones" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" ControlStyle-CssClass="btn-info" />
                                </Columns>
                                <FooterStyle BackColor="#CCCCCC" />
                                <HeaderStyle BackColor="Black" CssClass="thead-dark" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" VerticalAlign="Middle" />
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

</asp:Content>

