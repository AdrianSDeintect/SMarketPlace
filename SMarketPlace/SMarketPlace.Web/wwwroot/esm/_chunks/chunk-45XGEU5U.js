import{a as t,c as r,e as l,f as n,g}from"./chunk-FEDAVPE7.js";var b=class{};t(b,"TblArticuloColumns"),b.columnsKey="Productos.TblArticulo";var y=r(n(),1);var p=class{static getLookup(){return(0,y.getLookup)("Productos.TblArticulo")}static getLookupAsync(){return l(this,null,function*(){return(0,y.getLookupAsync)("Productos.TblArticulo")})}};t(p,"TblArticuloRow"),p.idProperty="Sku",p.nameProperty="Nombrearticulo",p.localTextPrefix="Productos.TblArticulo",p.lookupKey="Productos.TblArticulo",p.deletePermission="Productos",p.insertPermission="Productos",p.readPermission="Productos",p.updatePermission="Productos",p.Fields=(0,y.fieldsProxy)();var T=r(n(),1),X;(e=>(e.baseUrl="Productos/TblArticulo",e.Methods={Create:"Productos/TblArticulo/Create",Update:"Productos/TblArticulo/Update",Delete:"Productos/TblArticulo/Delete",Retrieve:"Productos/TblArticulo/Retrieve",List:"Productos/TblArticulo/List"},["Create","Update","Delete","Retrieve","List"].forEach(i=>{e[i]=function(s,m,x){return(0,T.serviceRequest)(e.baseUrl+"/"+i,s,m,x)}})))(X||(X={}));var E=class{};t(E,"TblproductosDidiColumns"),E.columnsKey="Productos.TblproductosDidi";var v=r(n(),1);var u=class{static getLookup(){return(0,v.getLookup)("Productos.TblproductosDidi")}static getLookupAsync(){return l(this,null,function*(){return(0,v.getLookupAsync)("Productos.TblproductosDidi")})}};t(u,"TblproductosDidiRow"),u.idProperty="IntArticuloid",u.nameProperty="IntArticuloid",u.localTextPrefix="Productos.TblproductosDidi",u.lookupKey="Productos.TblproductosDidi",u.deletePermission="Productos:Didi",u.insertPermission="Productos:Didi",u.readPermission="Productos:Didi",u.updatePermission="Productos:Didi",u.Fields=(0,v.fieldsProxy)();var h=r(n(),1),C;(e=>(e.baseUrl="Productos/TblproductosDidi",e.Methods={Create:"Productos/TblproductosDidi/Create",Update:"Productos/TblproductosDidi/Update",Delete:"Productos/TblproductosDidi/Delete",Retrieve:"Productos/TblproductosDidi/Retrieve",List:"Productos/TblproductosDidi/List",ExcelImport:"Productos/TblproductosDidi/ExcelImport",DeleteMulti:"Productos/TblproductosDidi/DeleteMulti"},["Create","Update","Delete","Retrieve","List","ExcelImport","DeleteMulti"].forEach(i=>{e[i]=function(s,m,x){return(0,h.serviceRequest)(e.baseUrl+"/"+i,s,m,x)}})))(C||(C={}));var I=class{};t(I,"TblproductosRappiColumns"),I.columnsKey="Productos.TblproductosRappi";var P=r(n(),1);var a=class{static getLookup(){return(0,P.getLookup)("Productos.TblproductosRappi")}static getLookupAsync(){return l(this,null,function*(){return(0,P.getLookupAsync)("Productos.TblproductosRappi")})}};t(a,"TblproductosRappiRow"),a.idProperty="IntArticuloid",a.nameProperty="IntArticuloid",a.localTextPrefix="Productos.TblproductosRappi",a.lookupKey="Productos.TblproductosRappi",a.deletePermission="Productos:Rappi",a.insertPermission="Productos:Rappi",a.readPermission="Productos:Rappi",a.updatePermission="Productos:Rappi",a.Fields=(0,P.fieldsProxy)();var N=r(n(),1),K;(e=>(e.baseUrl="Productos/TblproductosRappi",e.Methods={Create:"Productos/TblproductosRappi/Create",Update:"Productos/TblproductosRappi/Update",Delete:"Productos/TblproductosRappi/Delete",Retrieve:"Productos/TblproductosRappi/Retrieve",List:"Productos/TblproductosRappi/List",ExcelImport:"Productos/TblproductosRappi/ExcelImport",DeleteMulti:"Productos/TblproductosRappi/DeleteMulti"},["Create","Update","Delete","Retrieve","List","ExcelImport","DeleteMulti"].forEach(i=>{e[i]=function(s,m,x){return(0,N.serviceRequest)(e.baseUrl+"/"+i,s,m,x)}})))(K||(K={}));var O=class{};t(O,"TblproductosUberColumns"),O.columnsKey="Productos.TblproductosUber";var f=r(n(),1);var d=class{static getLookup(){return(0,f.getLookup)("Productos.TblproductosUber")}static getLookupAsync(){return l(this,null,function*(){return(0,f.getLookupAsync)("Productos.TblproductosUber")})}};t(d,"TblproductosUberRow"),d.idProperty="IntArticuloid",d.nameProperty="IntArticuloid",d.localTextPrefix="Productos.TblproductosUber",d.lookupKey="Productos.TblproductosUber",d.deletePermission="Productos:Uber",d.insertPermission="Productos:Uber",d.readPermission="Productos:Uber",d.updatePermission="Productos:Uber",d.Fields=(0,f.fieldsProxy)();var j=r(n(),1),G;(e=>(e.baseUrl="Productos/TblproductosUber",e.Methods={Create:"Productos/TblproductosUber/Create",Update:"Productos/TblproductosUber/Update",Delete:"Productos/TblproductosUber/Delete",Retrieve:"Productos/TblproductosUber/Retrieve",List:"Productos/TblproductosUber/List",ExcelImport:"Productos/TblproductosUber/ExcelImport",DeleteMulti:"Productos/TblproductosUber/DeleteMulti"},["Create","Update","Delete","Retrieve","List","ExcelImport","DeleteMulti"].forEach(i=>{e[i]=function(s,m,x){return(0,j.serviceRequest)(e.baseUrl+"/"+i,s,m,x)}})))(G||(G={}));var z;(s=>(s.Productos="Productos",s.Didi="Productos:Didi",s.Rappi="Productos:Rappi",s.Uber="Productos:Uber"))(z||(z={}));var R=r(g(),1),B=r(n(),1);var S=class extends R.PrefixedContext{constructor(c){if(super(c),!S.init){S.init=!0;var e=R.StringEditor,i=R.IntegerEditor,s=R.DecimalEditor;(0,B.initFormType)(S,["Nombrearticulo",e,"Categorialealtad",i,"Division",e,"Categoria",e,"Subcategoria",e,"Grupo",e,"Proveedor",e,"Iva",s,"Codbar",e,"ParametroProducto",e,"MapMod",e,"Precio",s])}}},U=S;t(U,"TblArticuloForm"),U.formKey="Productos.TblArticulo";var M=r(g(),1),F=r(n(),1);var q=class extends M.PrefixedContext{constructor(c){if(super(c),!q.init){q.init=!0;var e=M.LookupEditor;(0,F.initFormType)(q,["IntArticuloid",e])}}},k=q;t(k,"TblproductosDidiForm"),k.formKey="Productos.TblproductosDidi";var H=r(g(),1),V=r(n(),1);var D=class extends H.PrefixedContext{constructor(c){if(super(c),!D.init){D.init=!0;var e=H.LookupEditor;(0,V.initFormType)(D,["IntArticuloid",e])}}},A=D;t(A,"TblproductosRappiForm"),A.formKey="Productos.TblproductosRappi";var Q=r(g(),1),W=r(n(),1);var L=class extends Q.PrefixedContext{constructor(c){if(super(c),!L.init){L.init=!0;var e=Q.LookupEditor;(0,W.initFormType)(L,["IntArticuloid",e])}}},J=L;t(J,"TblproductosUberForm"),J.formKey="Productos.TblproductosUber";export{b as a,U as b,p as c,X as d,E as e,k as f,u as g,C as h,I as i,A as j,a as k,K as l,O as m,J as n,d as o,G as p};
//# sourceMappingURL=chunk-45XGEU5U.js.map