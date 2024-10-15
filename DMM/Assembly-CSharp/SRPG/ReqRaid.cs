// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRaid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002FC2")]
  public class ReqRaid : WebAPI
  {
    [Token(Token = "0x600DC16")]
    [Address(RVA = "0xA79960", Offset = "0xA78760", VA = "0x10A79960")]
    public ReqRaid(Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002FC3")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EAC1")]
      [FieldOffset(Offset = "0x8")]
      public int period_id;
      [Token(Token = "0x400EAC2")]
      [FieldOffset(Offset = "0xC")]
      public int round;
      [Token(Token = "0x400EAC3")]
      [FieldOffset(Offset = "0x10")]
      public int area_id;
      [Token(Token = "0x400EAC4")]
      [FieldOffset(Offset = "0x14")]
      public int is_area_reward;
      [Token(Token = "0x400EAC5")]
      [FieldOffset(Offset = "0x18")]
      public int is_raid_complete_reward;
      [Token(Token = "0x400EAC6")]
      [FieldOffset(Offset = "0x1C")]
      public Json_RaidBP bp;
      [Token(Token = "0x400EAC7")]
      [FieldOffset(Offset = "0x20")]
      public JSON_RaidBossData raidboss_current;
      [Token(Token = "0x400EAC8")]
      [FieldOffset(Offset = "0x24")]
      public JSON_RaidBossData rescue_current;
      [Token(Token = "0x400EAC9")]
      [FieldOffset(Offset = "0x28")]
      public JSON_RaidBossInfo[] raidboss_knock_down;

      [Token(Token = "0x600DC17")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
