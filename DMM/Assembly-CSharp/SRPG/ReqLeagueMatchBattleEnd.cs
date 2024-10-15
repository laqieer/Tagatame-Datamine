// Decompiled with JetBrains decompiler
// Type: SRPG.ReqLeagueMatchBattleEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002F85")]
  public class ReqLeagueMatchBattleEnd : WebAPI
  {
    [Token(Token = "0x600DBD8")]
    [Address(RVA = "0xA757C0", Offset = "0xA745C0", VA = "0x10A757C0")]
    public ReqLeagueMatchBattleEnd(
      long _btlid,
      BtlResultTypes result,
      JSON_LeagueMatchBattleDetail _detail,
      string _trophy_progs,
      string _bingo_progs,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002F86")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EA51")]
      [FieldOffset(Offset = "0x8")]
      public long btlid;
      [Token(Token = "0x400EA52")]
      [FieldOffset(Offset = "0x10")]
      public int is_win;
      [Token(Token = "0x400EA53")]
      [FieldOffset(Offset = "0x14")]
      public JSON_LeagueMatchBattleDetail detail;

      [Token(Token = "0x600DBD9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
