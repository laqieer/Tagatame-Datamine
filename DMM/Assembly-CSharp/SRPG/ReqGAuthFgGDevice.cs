// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGAuthFgGDevice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003175")]
  public class ReqGAuthFgGDevice : WebAPI
  {
    [Token(Token = "0x600DE0B")]
    [Address(RVA = "0xA96BD0", Offset = "0xA959D0", VA = "0x10A96BD0")]
    public ReqGAuthFgGDevice(
      string deviceID,
      string mail,
      string password,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003176")]
    public class Json_FggDevice
    {
      [Token(Token = "0x400ED3D")]
      [FieldOffset(Offset = "0x8")]
      public string device_id;
      [Token(Token = "0x400ED3E")]
      [FieldOffset(Offset = "0xC")]
      public string secret_key;

      [Token(Token = "0x600DE0C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_FggDevice()
      {
      }
    }
  }
}
