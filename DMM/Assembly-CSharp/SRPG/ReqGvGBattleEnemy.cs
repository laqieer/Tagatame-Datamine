// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGvGBattleEnemy
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
  [Token(Token = "0x200326F")]
  public class ReqGvGBattleEnemy : WebAPI
  {
    [Token(Token = "0x600DF10")]
    [Address(RVA = "0xA99130", Offset = "0xA97F30", VA = "0x10A99130")]
    public ReqGvGBattleEnemy(
      int id,
      int gid,
      int gvg_group_id,
      int page,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003270")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EEDD")]
      [FieldOffset(Offset = "0x8")]
      public int id;
      [Token(Token = "0x400EEDE")]
      [FieldOffset(Offset = "0xC")]
      public int gid;
      [Token(Token = "0x400EEDF")]
      [FieldOffset(Offset = "0x10")]
      public int gvg_group_id;
      [Token(Token = "0x400EEE0")]
      [FieldOffset(Offset = "0x14")]
      public int page;

      [Token(Token = "0x600DF11")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003271")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EEE1")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GvGParty[] defenses;
      [Token(Token = "0x400EEE2")]
      [FieldOffset(Offset = "0xC")]
      public int refresh_wait_sec;
      [Token(Token = "0x400EEE3")]
      [FieldOffset(Offset = "0x10")]
      public int totalCount;
      [Token(Token = "0x400EEE4")]
      [FieldOffset(Offset = "0x14")]
      public int total_beat_defense_num;
      [Token(Token = "0x400EEE5")]
      [FieldOffset(Offset = "0x18")]
      public int total_beat_offense_num;
      [Token(Token = "0x400EEE6")]
      [FieldOffset(Offset = "0x1C")]
      public int totalPage;
      [Token(Token = "0x400EEE7")]
      [FieldOffset(Offset = "0x20")]
      public int auto_refresh_wait_sec;

      [Token(Token = "0x600DF12")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
