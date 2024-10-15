// Decompiled with JetBrains decompiler
// Type: SRPG.ReqBtlMultiTwReq
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200316D")]
  public class ReqBtlMultiTwReq : WebAPI
  {
    [Token(Token = "0x600DE03")]
    [Address(RVA = "0xA951B0", Offset = "0xA93FB0", VA = "0x10A951B0")]
    public ReqBtlMultiTwReq(
      string iname,
      int partyIndex,
      int plid,
      int seat,
      string[] uid,
      Network.ResponseCallback response)
    {
    }
  }
}
