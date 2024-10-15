// Decompiled with JetBrains decompiler
// Type: SRPG.ReqBtlComCont
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20030B0")]
  public class ReqBtlComCont : WebAPI
  {
    [Token(Token = "0x600DD30")]
    [Address(RVA = "0xA809C0", Offset = "0xA7F7C0", VA = "0x10A809C0")]
    public ReqBtlComCont(
      long btlid,
      BattleCore.Record record,
      Network.ResponseCallback response,
      bool multi,
      bool isMT)
    {
    }
  }
}
