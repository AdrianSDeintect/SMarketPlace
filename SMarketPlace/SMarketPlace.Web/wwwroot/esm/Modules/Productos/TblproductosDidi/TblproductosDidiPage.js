import{a as f}from"../../../_chunks/chunk-K3EX7A2V.js";import"../../../_chunks/chunk-NJQUU2H4.js";import{a as S}from"../../../_chunks/chunk-HHAWTOGR.js";import{e as g,f as u,g as e,h as l}from"../../../_chunks/chunk-45XGEU5U.js";import{a as n,c,d,f as w,g as m}from"../../../_chunks/chunk-FEDAVPE7.js";var P=c(w(),1);var o=c(m(),1);var p=c(m(),1);var i=class extends p.EntityDialog{constructor(){super(...arguments);this.form=new u(this.idPrefix)}getFormKey(){return u.formKey}getIdProperty(){return e.idProperty}getLocalTextPrefix(){return e.localTextPrefix}getNameProperty(){return e.nameProperty}getService(){return l.baseUrl}getModifyPermisison(){return e.updatePermission}getReadPermisison(){return e.readPermission}getDeletePermission(){return e.deletePermission}getInsertPermission(){return e.insertPermission}getUpdatePermission(){return e.updatePermission}};n(i,"TblproductosDidiDialog"),i=d([p.Decorators.registerClass("SMarketPlace.Productos.TblproductosDidiDialog")],i);var a=c(S(),1);var s=class extends o.EntityGrid{constructor(t){super(t);this.rowSelection=new o.GridRowSelectionMixin(this)}getColumnsKey(){return g.columnsKey}getDialogType(){return i}getRowDefinition(){return e}getService(){return l.baseUrl}createToolbarExtensions(){super.createToolbarExtensions(),this.rowSelection=new o.GridRowSelectionMixin(this)}getColumns(){var t=super.getColumns();return t.splice(0,0,o.GridRowSelectionMixin.createSelectColumn(()=>this.rowSelection)),t}getButtons(){var t=super.getButtons();return t.push(a.ExcelExportHelper.createToolButton({grid:this,service:l.baseUrl+"/ListExcel",onViewSubmit:()=>this.onViewSubmit(),separator:!0})),t.push(a.PdfExportHelper.createToolButton({grid:this,onViewSubmit:()=>this.onViewSubmit()})),t.push({title:"Eliminar",cssClass:"text-red",icon:"fa-times text-red",onClick:()=>{let r=this.rowSelection.getSelectedKeys();this.rowSelection.resetCheckedAndRefresh(),r!=null&&typeof r!="undefined"&&r.length>0?Q.confirm("Confirma borrado de Productos ? ",()=>{l.DeleteMulti({Ids:r},b=>{Q.notifySuccess("Productos Eliminados"),this.refresh()})},{onNo:()=>{Q.notifyInfo("Productos no Eliminados")},onCancel:()=>{Q.notifyError("Operacion Cancelada")},dialogClass:"s-MessageDialog s-WarningDialog"}):Q.warning("Seleccionar un producto para eliminar")}}),t.push({title:"Import From Excel",cssClass:"export-xlsx-button",onClick:()=>{var r=new f({});r.element.on("dialogclose",()=>{this.refresh(),r=null}),r.TipoMP="Didi",r.dialogOpen()}}),t}};n(s,"TblproductosDidiGrid"),s=d([o.Decorators.registerClass("SMarketPlace.Productos.TblproductosDidiGrid")],s);function y(){(0,P.initFullHeightGridPage)(new s($("#GridDiv")).element)}n(y,"pageInit");export{y as default};
//# sourceMappingURL=TblproductosDidiPage.js.map
