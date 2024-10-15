// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.API.Response.ChargeV2Limit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Gsc.Purchase.API.App;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.Purchase.API.Response
{
  [Token(Token = "0x2003622")]
  public class ChargeV2Limit : GenericResponse<ChargeV2Limit>
  {
    [Token(Token = "0x17002283")]
    public int Age
    {
      [Token(Token = "0x600F160"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600F161"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x17002284")]
    public bool HasCreditLimit
    {
      [Token(Token = "0x600F162"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F163"), Address(RVA = "0x3DA460", Offset = "0x3D9260", VA = "0x103DA460")] private set
      {
      }
    }

    [Token(Token = "0x17002285")]
    public float CreditLimit
    {
      [Token(Token = "0x600F164"), Address(RVA = "0x2CD710", Offset = "0x2CC510", VA = "0x102CD710")] get
      {
        return new float();
      }
      [Token(Token = "0x600F165"), Address(RVA = "0xB20590", Offset = "0xB1F390", VA = "0x10B20590")] private set
      {
      }
    }

    [Token(Token = "0x600F166")]
    [Address(RVA = "0xB20240", Offset = "0xB1F040", VA = "0x10B20240")]
    public ChargeV2Limit(WebInternalResponse response)
    {
    }
  }
}
