// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRaidRewardRescueComplete
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002FCF")]
  public class ReqRaidRewardRescueComplete : WebAPI
  {
    [Token(Token = "0x600DC23")]
    [Address(RVA = "0xA796F0", Offset = "0xA784F0", VA = "0x10A796F0")]
    public ReqRaidRewardRescueComplete(Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002FD0")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EAEE")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x400EAEF")]
      [FieldOffset(Offset = "0xC")]
      public Json_Item[] items;
      [Token(Token = "0x400EAF0")]
      [FieldOffset(Offset = "0x10")]
      public Json_Unit[] units;
      [Token(Token = "0x400EAF1")]
      [FieldOffset(Offset = "0x14")]
      public JSON_ConceptCard[] cards;
      [Token(Token = "0x400EAF2")]
      [FieldOffset(Offset = "0x18")]
      public Json_Artifact[] artifacts;
      [Token(Token = "0x400EAF3")]
      [FieldOffset(Offset = "0x1C")]
      public Json_Gift[] reward;
      [Token(Token = "0x400EAF4")]
      [FieldOffset(Offset = "0x20")]
      private int round;
      [Token(Token = "0x400EAF5")]
      [FieldOffset(Offset = "0x24")]
      public JSON_TrophyProgress[] trophyprogs;
      [Token(Token = "0x400EAF6")]
      [FieldOffset(Offset = "0x28")]
      public JSON_TrophyProgress[] bingoprogs;
      [Token(Token = "0x400EAF7")]
      [FieldOffset(Offset = "0x2C")]
      public Json_RuneData[] runes_detail;
      [Token(Token = "0x400EAF8")]
      [FieldOffset(Offset = "0x30")]
      public int rune_storage_used;

      [Token(Token = "0x600DC24")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
