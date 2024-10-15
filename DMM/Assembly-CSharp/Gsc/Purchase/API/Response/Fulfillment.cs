// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.API.Response.Fulfillment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Gsc.Purchase.API.App;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.Purchase.API.Response
{
  [Token(Token = "0x2003624")]
  public class Fulfillment : GenericResponse<Fulfillment>
  {
    [Token(Token = "0x17002286")]
    public FulfillmentResult Result
    {
      [Token(Token = "0x600F16A"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (FulfillmentResult) null;
      }
      [Token(Token = "0x600F16B"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x600F16C")]
    [Address(RVA = "0xB235D0", Offset = "0xB223D0", VA = "0x10B235D0")]
    public Fulfillment(WebInternalResponse response)
    {
    }
  }
}
