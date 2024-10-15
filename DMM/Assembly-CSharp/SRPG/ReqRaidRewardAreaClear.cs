// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRaidRewardAreaClear
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002FCC")]
  public class ReqRaidRewardAreaClear : WebAPI
  {
    [Token(Token = "0x600DC20")]
    [Address(RVA = "0xA794D0", Offset = "0xA782D0", VA = "0x10A794D0")]
    public ReqRaidRewardAreaClear(int area_id, int round, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002FCD")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EAE2")]
      [FieldOffset(Offset = "0x8")]
      public int area_id;
      [Token(Token = "0x400EAE3")]
      [FieldOffset(Offset = "0xC")]
      public int round;

      [Token(Token = "0x600DC21")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002FCE")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EAE4")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x400EAE5")]
      [FieldOffset(Offset = "0xC")]
      public Json_Item[] items;
      [Token(Token = "0x400EAE6")]
      [FieldOffset(Offset = "0x10")]
      public Json_Unit[] units;
      [Token(Token = "0x400EAE7")]
      [FieldOffset(Offset = "0x14")]
      public JSON_ConceptCard[] cards;
      [Token(Token = "0x400EAE8")]
      [FieldOffset(Offset = "0x18")]
      public Json_Artifact[] artifacts;
      [Token(Token = "0x400EAE9")]
      [FieldOffset(Offset = "0x1C")]
      public Json_Gift[] reward;
      [Token(Token = "0x400EAEA")]
      [FieldOffset(Offset = "0x20")]
      public JSON_TrophyProgress[] trophyprogs;
      [Token(Token = "0x400EAEB")]
      [FieldOffset(Offset = "0x24")]
      public JSON_TrophyProgress[] bingoprogs;
      [Token(Token = "0x400EAEC")]
      [FieldOffset(Offset = "0x28")]
      public Json_RuneData[] runes_detail;
      [Token(Token = "0x400EAED")]
      [FieldOffset(Offset = "0x2C")]
      public int rune_storage_used;

      [Token(Token = "0x600DC22")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
