// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGvGNodeDefenseEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003269")]
  public class ReqGvGNodeDefenseEntry : WebAPI
  {
    [Token(Token = "0x600DF0A")]
    [Address(RVA = "0xA99870", Offset = "0xA98670", VA = "0x10A99870")]
    public ReqGvGNodeDefenseEntry(
      int id,
      int gid,
      int gvg_group_id,
      int page,
      int is_force,
      List<JSON_GvGUnitOverWriteData> party,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x200326A")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EEBF")]
      [FieldOffset(Offset = "0x8")]
      public int id;
      [Token(Token = "0x400EEC0")]
      [FieldOffset(Offset = "0xC")]
      public int gid;
      [Token(Token = "0x400EEC1")]
      [FieldOffset(Offset = "0x10")]
      public int gvg_group_id;
      [Token(Token = "0x400EEC2")]
      [FieldOffset(Offset = "0x14")]
      public int page;
      [Token(Token = "0x400EEC3")]
      [FieldOffset(Offset = "0x18")]
      public List<JSON_GvGUnitOverWriteData> party;
      [Token(Token = "0x400EEC4")]
      [FieldOffset(Offset = "0x1C")]
      public int is_force;

      [Token(Token = "0x600DF0B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x200326B")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EEC5")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GvGParty[] defenses;
      [Token(Token = "0x400EEC6")]
      [FieldOffset(Offset = "0xC")]
      public JSON_GvGUsedUnitData[] used_units;
      [Token(Token = "0x400EEC7")]
      [FieldOffset(Offset = "0x10")]
      public int totalPage;
      [Token(Token = "0x400EEC8")]
      [FieldOffset(Offset = "0x14")]
      public int total_beat_num;
      [Token(Token = "0x400EEC9")]
      [FieldOffset(Offset = "0x18")]
      public JSON_GvGUsedItems[] unavailable_items;
      [Token(Token = "0x400EECA")]
      [FieldOffset(Offset = "0x1C")]
      public int[] used_cards;
      [Token(Token = "0x400EECB")]
      [FieldOffset(Offset = "0x20")]
      public int[] used_artifacts;
      [Token(Token = "0x400EECC")]
      [FieldOffset(Offset = "0x24")]
      public int[] used_runes;
      [Token(Token = "0x400EECD")]
      [FieldOffset(Offset = "0x28")]
      public long[] used_crystals;

      [Token(Token = "0x600DF0C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
