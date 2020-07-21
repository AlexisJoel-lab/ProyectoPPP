<%@ Page Title="Clientes" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="frmCliente.aspx.vb" Inherits="SistemaWeb_Ventas.frmCliente" ClientIDMode="Static"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!-- page content -->
    <div class="right_col" role="main">
        <div class="">
            <div class="page-title">
                <div class="title_left">
                    <h3>Formulario de Clientes</h3>
                </div>
            </div>

            <div class="clearfix"></div>

            <div class="row" id="Hide">
                <div class="col-md-12 col-sm-12  ">
                    <div class="x_panel">
                        <div class="x_title">
                            <h2>Mantenimiento de Cliente</h2>
                            <ul class="nav navbar-right panel_toolbox">
                                <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                                </li>
                            </ul>
                            <div class="clearfix"></div>
                        </div>
                        <div class="x_content">
                            <div class="row">
                                <div class="col-md-6">

                                    <div class="field item form-group">
                                        <label class="col-form-label col-md-3 col-sm-3  label-align">
                                            Nombre<span
                                                class="required">*</span></label>
                                        <div class="col-md-6 col-sm-6">
                                            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" TabIndex="1" required="required"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="field item form-group">
                                        <label class="col-form-label col-md-3 col-sm-3  label-align">
                                            Apellido Paterno<span
                                                class="required">*</span></label>
                                        <div class="col-md-6 col-sm-6">
                                            <asp:TextBox ID="txtApePaterno" runat="server" CssClass="form-control" TabIndex="2" required="required"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="field item form-group">
                                        <label class="col-form-label col-md-3 col-sm-3  label-align">
                                            Apellido Materno<span class="required">*</span></label>
                                        <div class="col-md-6 col-sm-6">
                                            <asp:TextBox ID="txtApeMaterno" runat="server" CssClass="form-control" TabIndex="3" required="required"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="field item form-group">
                                        <label class="col-form-label col-md-3 col-sm-3  label-align">
                                            DNI<span class="required">*</span></label>
                                        <div class="col-md-6 col-sm-6">
                                            <asp:TextBox ID="txtDNI" runat="server" CssClass="form-control" TabIndex="4" required="required"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="item form-group">
                                        <label class="col-form-label col-md-3 col-sm-3 label-align">
                                            Genero<span class="required">*</span></label>
                                        <div class="col-md-6 col-sm-6">                                            
                                            <asp:RadioButton ID="rbtMales" runat="server" CssClass="flat" GroupName="rbtGroupGenero" required="required" Text="  Masculino" />
                                            <asp:RadioButton ID="rbtFemale" runat="server" CssClass="flat" GroupName="rbtGroupGenero" required="required" Text="  Femenina" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-6">

                                    <div class="field item form-group">
                                        <label class="col-form-label col-md-3 col-sm-3  label-align">
                                            Teléfono<span class="required">*</span></label>
                                        <div class="col-md-6 col-sm-6">
                                            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" TabIndex="6" required="required"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="field item form-group">
                                        <label class="col-form-label col-md-3 col-sm-3  label-align">
                                            Dirección<span class="required">*</span></label>
                                        <div class="col-md-6 col-sm-6">
                                            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" TabIndex="7" required="required"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="field item form-group">
                                        <label class="col-form-label col-md-3 col-sm-3  label-align">
                                            Email<span class="required">*</span></label>
                                        <div class="col-md-6 col-sm-6">
                                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TabIndex="8" required="required"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="field item form-group">
                                        <label class="col-form-label col-md-3 col-sm-3  label-align">
                                            Estado<span class="required">*</span></label>
                                        <div class="col-md-6 col-sm-6">
                                            <asp:DropDownList ID="cbEstado" runat="server" CssClass="form-control" TabIndex="9">
                                                <asp:ListItem>Seleccionar estado:</asp:ListItem>
                                                <asp:ListItem Value="E">Eventual</asp:ListItem>
                                                <asp:ListItem Value="H">Habitual</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12 col-xs-12">
                                    <div class="ln_solid"></div>

                                    <div class="form-group row">
                                        <div class="col-md-9 offset-md-5">
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
                            <h2>Listado de clientes</h2>
                            <ul class="nav navbar-right panel_toolbox">
                                <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                                </li>
                            </ul>
                            <div class="clearfix"></div>
                        </div>
                        <div class="x_content">
                            <asp:Button ID="btnShowForm" runat="server" Height="36px" Text="Nuevo Cliente" TabIndex="7" CssClass="btn btn-primary" /><br />
                            <asp:GridView ID="tblCliente" runat="server" CssClass="table table-striped table-bordered dt-responsive nowrap" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" ShowHeaderWhenEmpty="True">
                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                <Columns>
                                    <asp:CommandField ButtonType="Button" HeaderText="OPCIONES" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" ControlStyle-CssClass="btn-info" />
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
    <!-- /page content -->
</asp:Content>

