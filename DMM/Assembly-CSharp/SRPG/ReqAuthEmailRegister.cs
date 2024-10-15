// Decompiled with JetBrains decompiler
// Type: SRPG.ReqAuthEmailRegister
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003085")]
  public class ReqAuthEmailRegister : WebAPI
  {
    [Token(Token = "0x600DCFF")]
    [Address(RVA = "0xA6D3A0", Offset = "0xA6C1A0", VA = "0x10A6D3A0")]
    public ReqAuthEmailRegister(
      string email,
      string password,
      string device_id,
      string secret_key,
      string udid,
      Network.ResponseCallback response)
    {
    }
  }
}
