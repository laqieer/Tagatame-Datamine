// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildRaidBtlReq
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002F20")]
  public class ReqGuildRaidBtlReq : WebAPI
  {
    [Token(Token = "0x600DB6F")]
    [Address(RVA = "0xA72440", Offset = "0xA71240", VA = "0x10A72440")]
    public ReqGuildRaidBtlReq(
      int gid,
      int round,
      int boss_id,
      GuildRaidBattleType battle_type,
      int unit_strength_total,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002F21")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E9B4")]
      [FieldOffset(Offset = "0x8")]
      public int gid;
      [Token(Token = "0x400E9B5")]
      [FieldOffset(Offset = "0xC")]
      public int round;
      [Token(Token = "0x400E9B6")]
      [FieldOffset(Offset = "0x10")]
      public int boss_id;
      [Token(Token = "0x400E9B7")]
      [FieldOffset(Offset = "0x14")]
      public int battle_type;
      [Token(Token = "0x400E9B8")]
      [FieldOffset(Offset = "0x18")]
      public int unit_strength_total;

      [Token(Token = "0x600DB70")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
