// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildRaidInfo
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
  [Token(Token = "0x2002F1D")]
  public class ReqGuildRaidInfo : WebAPI
  {
    [Token(Token = "0x600DB6C")]
    [Address(RVA = "0xA72670", Offset = "0xA71470", VA = "0x10A72670")]
    public ReqGuildRaidInfo(
      int gid,
      int boss_id,
      int round,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002F1E")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E9AF")]
      [FieldOffset(Offset = "0x8")]
      public int gid;
      [Token(Token = "0x400E9B0")]
      [FieldOffset(Offset = "0xC")]
      public int round;
      [Token(Token = "0x400E9B1")]
      [FieldOffset(Offset = "0x10")]
      public int boss_id;

      [Token(Token = "0x600DB6D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F1F")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E9B2")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GuildRaidBossInfo boss_info;
      [Token(Token = "0x400E9B3")]
      [FieldOffset(Offset = "0xC")]
      public JSON_GuildRaidChallengingPlayer[] players_challenging;

      [Token(Token = "0x600DB6E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
