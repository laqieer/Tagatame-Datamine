// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGvGBattle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200326C")]
  public class ReqGvGBattle : WebAPI
  {
    [Token(Token = "0x600DF0D")]
    [Address(RVA = "0xA99320", Offset = "0xA98120", VA = "0x10A99320")]
    public ReqGvGBattle(
      int id,
      int gid,
      int gvg_group_id,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x200326D")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EECE")]
      [FieldOffset(Offset = "0x8")]
      public int id;
      [Token(Token = "0x400EECF")]
      [FieldOffset(Offset = "0xC")]
      public int gid;
      [Token(Token = "0x400EED0")]
      [FieldOffset(Offset = "0x10")]
      public int gvg_group_id;

      [Token(Token = "0x600DF0E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x200326E")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EED1")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GvGPartyUnit[] offense;
      [Token(Token = "0x400EED2")]
      [FieldOffset(Offset = "0xC")]
      public int win_num;
      [Token(Token = "0x400EED3")]
      [FieldOffset(Offset = "0x10")]
      public int beat_num;
      [Token(Token = "0x400EED4")]
      [FieldOffset(Offset = "0x14")]
      public int seed;
      [Token(Token = "0x400EED5")]
      [FieldOffset(Offset = "0x18")]
      public JSON_GvGUsedUnitData[] used_units;
      [Token(Token = "0x400EED6")]
      [FieldOffset(Offset = "0x1C")]
      public int cool_time;
      [Token(Token = "0x400EED7")]
      [FieldOffset(Offset = "0x20")]
      public int[] used_cards;
      [Token(Token = "0x400EED8")]
      [FieldOffset(Offset = "0x24")]
      public int[] used_artifacts;
      [Token(Token = "0x400EED9")]
      [FieldOffset(Offset = "0x28")]
      public int[] used_runes;
      [Token(Token = "0x400EEDA")]
      [FieldOffset(Offset = "0x2C")]
      public long[] used_crystals;
      [Token(Token = "0x400EEDB")]
      [FieldOffset(Offset = "0x30")]
      public int maxActionNum;
      [Token(Token = "0x400EEDC")]
      [FieldOffset(Offset = "0x34")]
      public JSON_PlayerBuff player_buff;

      [Token(Token = "0x600DF0F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
