// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.GAuth.GAuth.API.Response.AddDevice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Auth.GAuth.GAuth.API.Generic;
using Gsc.Network;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.Auth.GAuth.GAuth.API.Response
{
  [Token(Token = "0x2003668")]
  public class AddDevice : GAuthResponse<AddDevice>
  {
    [Token(Token = "0x1700231F")]
    public bool IsSucceeded
    {
      [Token(Token = "0x600F34F"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F350"), Address(RVA = "0x3011A0", Offset = "0x2FFFA0", VA = "0x103011A0")] private set
      {
      }
    }

    [Token(Token = "0x600F351")]
    [Address(RVA = "0xB1EDF0", Offset = "0xB1DBF0", VA = "0x10B1EDF0")]
    public AddDevice(WebInternalResponse response)
    {
    }
  }
}
