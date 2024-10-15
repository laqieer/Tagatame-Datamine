// Decompiled with JetBrains decompiler
// Type: SRPG.ReqLeagueMatchBattleReq
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002F83")]
  public class ReqLeagueMatchBattleReq : WebAPI
  {
    [Token(Token = "0x600DBD6")]
    [Address(RVA = "0xA75A10", Offset = "0xA74810", VA = "0x10A75A10")]
    public ReqLeagueMatchBattleReq(
      ReqLeagueMatchBattleReq.RequestParam param,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002F84")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EA4E")]
      [FieldOffset(Offset = "0x8")]
      public int party_no;
      [Token(Token = "0x400EA4F")]
      [FieldOffset(Offset = "0xC")]
      public string enemy_fuid;
      [Token(Token = "0x400EA50")]
      [FieldOffset(Offset = "0x10")]
      public int is_npc;

      [Token(Token = "0x600DBD7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
