using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SMarketPlace.Web.Modules.Ecommerce.ActualizarPedido;

public partial class TipoPedidosAttribute : CustomEditorAttribute
{
    public const string Key = "/Modules/Ecommerce/ActualizarPedido/TiposPedidos:SMarketPlace.Web.Modules.Ecommerce.ActualizarPedido.TipoPedidos";

    public TipoPedidosAttribute()
        : base(Key)
    {
    }
}