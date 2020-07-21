<%@ Page Title="Rol" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="frmRol.aspx.vb" Inherits="SistemaWeb_Ventas.frmRol" ClientIDMode="Static"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!-- page content -->
    <div class="right_col" role="main">
        <div class="">
            <div class="page-title">
                <div class="title_left">
                    <h3>Formulario de Rol</h3>
                </div>
            </div>

            <div class="clearfix"></div>

            <div class="row" id="Hide">
                <div class="col-md-12 col-sm-12  ">
                    <div class="x_panel">
                        <div class="x_title">
                            <h2>Mantenimiento de Rol</h2>
                            <ul class="nav navbar-right panel_toolbox">
                                <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                                </li>
                            </ul>
                            <div class="clearfix"></div>
                        </div>
                        <div class="x_content">
                            <%--</form>--%>
                            <div class="field item form-group">
                                <label class="col-form-label col-md-3 col-sm-3  label-align">
                                    Descripcion<span
                                        class="required">*</span></label>
                                <div class="col-md-6 col-sm-6">
                                    <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" TabIndex="1" required="required"></asp:TextBox>
                                </div>
                            </div>
                            <div class="ln_solid">
                                <div class="form-group">
                                    <div class="col-md-6 offset-md-3">
                                        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" TabIndex="2" CssClass="btn btn-primary" />
                                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" TabIndex="3" CssClass="btn btn-danger" />
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
                            <h2>Listado de Rol</h2>
                            <ul class="nav navbar-right panel_toolbox">
                                <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                                </li>
                            </ul>
                            <div class="clearfix"></div>
                        </div>
                        <div class="x_content">                            
                            <asp:Button ID="btnShowForm" runat="server" Height="36px" Text="Nuevo Rol" TabIndex="4" CssClass="btn btn-primary" />
                            <asp:Button ID="btnEditar" runat="server" Height="36px" Text="Editar" TabIndex="5" CssClass="btn btn-info" />
                            <asp:Button ID="btnElimiar" runat="server" Height="36px" Text="Eliminar" TabIndex="6" CssClass="btn btn-danger" />
                            
                            <asp:GridView ID="tblRol" runat="server" CssClass="table table-striped table-bordered dt-responsive nowrap" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" ShowHeaderWhenEmpty="True">
                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                <Columns>
                                    <asp:TemplateField>
                                        <EditItemTemplate>
                                            <asp:CheckBox ID="CheckBox1" runat="server" />
                                        </EditItemTemplate>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="ckbElegir" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
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
                            <%--<div class="row">
                                <div class="col-sm-12">
                                    <div class="card-box table-responsive">
                                        <table id="datatable-responsive" class="tblRol table table-striped table-bordered" style="width: 100%">
                                            <thead>
                                                <tr>
                                                    <th>CODIGO</th>
                                                    <th>ROL</th>
                                                    <th>FECHA CREACIÓN</th>
                                                    <th>OPCIONES</th>
                                                </tr>
                                            </thead>
                                            <tbody id="tbl_body_table">
                                                <%-- DATA-- 
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>--%>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- /page content -->
</asp:Content>
