// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGAuthMigrate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003173")]
  public class ReqGAuthMigrate : WebAPI
  {
    [Token(Token = "0x600DE09")]
    [Address(RVA = "0xA96E70", Offset = "0xA95C70", VA = "0x10A96E70")]
    public ReqGAuthMigrate(
      string secretKey,
      string deviceID,
      string passcode,
      Network.ResponseCallback response)
    {
    }
  }
}
