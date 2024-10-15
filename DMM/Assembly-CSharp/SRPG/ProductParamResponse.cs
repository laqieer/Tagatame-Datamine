// Decompiled with JetBrains decompiler
// Type: SRPG.ProductParamResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C22")]
  public class ProductParamResponse
  {
    [Token(Token = "0x4006D0F")]
    [FieldOffset(Offset = "0x8")]
    public List<ProductParam> products;

    [Token(Token = "0x60073E1")]
    [Address(RVA = "0x37FAB0", Offset = "0x37E8B0", VA = "0x1037FAB0")]
    public bool Deserialize(JSON_ProductParamResponse json) => new bool();

    [Token(Token = "0x60073E2")]
    [Address(RVA = "0x37FD60", Offset = "0x37EB60", VA = "0x1037FD60")]
    public ProductParamResponse()
    {
    }
  }
}
