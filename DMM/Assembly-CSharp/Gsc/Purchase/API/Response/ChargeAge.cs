// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.API.Response.ChargeAge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Gsc.Purchase.API.App;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.Purchase.API.Response
{
  [Token(Token = "0x2003621")]
  public class ChargeAge : GenericResponse<ChargeAge>
  {
    [Token(Token = "0x17002282")]
    public int Age
    {
      [Token(Token = "0x600F15D"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600F15E"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x600F15F")]
    [Address(RVA = "0xB1FEA0", Offset = "0xB1ECA0", VA = "0x10B1FEA0")]
    public ChargeAge(WebInternalResponse response)
    {
    }
  }
}
