// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.API.App.ProductList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Purchase.API.App
{
  [Token(Token = "0x2003653")]
  public class ProductList : GenericRequest<ProductList, Gsc.Purchase.API.Response.ProductList>
  {
    [Token(Token = "0x400FF4E")]
    private const string ___path = "/api{0}/{1}/products";

    [Token(Token = "0x600F2D6")]
    [Address(RVA = "0xB254A0", Offset = "0xB242A0", VA = "0x10B254A0")]
    public ProductList()
    {
    }

    [Token(Token = "0x600F2D7")]
    [Address(RVA = "0xB25150", Offset = "0xB23F50", VA = "0x10B25150", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F2D8")]
    [Address(RVA = "0xB25120", Offset = "0xB23F20", VA = "0x10B25120", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F2D9")]
    [Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }
  }
}
