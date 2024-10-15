// Decompiled with JetBrains decompiler
// Type: SRPG.ReqDuelBattleReq
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002EDB")]
  public class ReqDuelBattleReq : WebAPI
  {
    [Token(Token = "0x600DB27")]
    [Address(RVA = "0xA6F360", Offset = "0xA6E160", VA = "0x10A6F360")]
    public ReqDuelBattleReq(
      string fuid,
      Json_Unit[] party,
      string _trophy_progs,
      string _bingo_progs,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002EDC")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E927")]
      [FieldOffset(Offset = "0x8")]
      public string enemy_fuid;
      [Token(Token = "0x400E928")]
      [FieldOffset(Offset = "0xC")]
      public Json_Unit[] enemy_party;

      [Token(Token = "0x600DB28")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
