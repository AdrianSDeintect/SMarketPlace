import{a as f}from"../../../_chunks/chunk-6HW343Q7.js";import{g,h as m,i as r,j as l}from"../../../_chunks/chunk-7NM4SQ3Z.js";import{b as y}from"../../../_chunks/chunk-F5ADXQSZ.js";import{a as n,c as u,d as a,f as x,g as d}from"../../../_chunks/chunk-FEDAVPE7.js";var S=u(x(),1);var s=u(d(),1);var c=u(d(),1);var o=class extends c.EntityDialog{constructor(){super(...arguments);this.form=new m(this.idPrefix)}getFormKey(){return m.formKey}getRowDefinition(){return r}getService(){return l.baseUrl}getModifyPermisison(){return r.updatePermission}getReadPermisison(){return r.readPermission}getDeletePermission(){return r.deletePermission}getInsertPermission(){return r.insertPermission}getUpdatePermission(){return r.updatePermission}};n(o,"TblSucursalRappiDialog"),o=a([c.Decorators.registerClass("SMarketPlace.Sucursales.TblSucursalRappiDialog")],o);var p=u(y(),1);var i=class extends s.EntityGrid{constructor(e){super(e);this.rowSelection=new s.GridRowSelectionMixin(this)}getColumnsKey(){return g.columnsKey}getDialogType(){return o}getRowDefinition(){return r}getService(){return l.baseUrl}getColumns(){let e=super.getColumns();return e.splice(0,0,s.GridRowSelectionMixin.createSelectColumn(()=>this.rowSelection)),e}getButtons(){var e=super.getButtons();return e.push(p.ExcelExportHelper.createToolButton({grid:this,service:l.baseUrl+"/ListExcel",onViewSubmit:()=>this.onViewSubmit(),separator:!0})),e.push(p.PdfExportHelper.createToolButton({grid:this,onViewSubmit:()=>this.onViewSubmit()})),e.push({title:"Eliminar",cssClass:"text-red",icon:"fa-times text-red",onClick:()=>{let t=this.rowSelection.getSelectedKeys();t!=null&&typeof t!="undefined"&&t.length>0?Q.confirm("Confirma borrado de Sucursales ? ",()=>{l.DeleteMulti({Ids:t},P=>{Q.notifySuccess("Sucursales Eliminadas"),this.refresh()})},{onNo:()=>{Q.notifyInfo("Sucursales no Eliminados")},onCancel:()=>{Q.notifyError("Operacion Cancelada")},dialogClass:"s-MessageDialog s-WarningDialog"}):Q.warning("Seleccionar una sucursal para eliminar")}}),e.push({title:"Import From Excel",cssClass:"export-xlsx-button",onClick:()=>{var t=new f({});t.element.on("dialogclose",()=>{this.refresh(),t=null}),t.TipoMP="Rappi",t.dialogOpen()}}),e}};n(i,"TblSucursalRappiGrid"),i=a([s.Decorators.registerClass("SMarketPlace.Sucursales.TblSucursalRappiGrid")],i);function C(){(0,S.initFullHeightGridPage)(new i($("#GridDiv")).element)}n(C,"pageInit");export{C as default};
//# sourceMappingURL=TblSucursalRappiPage.js.map