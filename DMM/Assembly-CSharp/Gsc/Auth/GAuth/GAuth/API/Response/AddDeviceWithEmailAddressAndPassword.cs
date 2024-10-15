// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.GAuth.GAuth.API.Response.AddDeviceWithEmailAddressAndPassword
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Auth.GAuth.GAuth.API.Generic;
using Gsc.Network;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.Auth.GAuth.GAuth.API.Response
{
  [Token(Token = "0x2003669")]
  public class AddDeviceWithEmailAddressAndPassword : 
    GAuthResponse<AddDeviceWithEmailAddressAndPassword>
  {
    [Token(Token = "0x17002320")]
    public string DeviceId
    {
      [Token(Token = "0x600F352"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F353"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17002321")]
    public string SecretKey
    {
      [Token(Token = "0x600F354"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F355"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x600F356")]
    [Address(RVA = "0xB1EB30", Offset = "0xB1D930", VA = "0x10B1EB30")]
    public AddDeviceWithEmailAddressAndPassword(WebInternalResponse response)
    {
    }
  }
}
