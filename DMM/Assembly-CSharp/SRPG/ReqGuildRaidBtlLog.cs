// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildRaidBtlLog
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
  [Token(Token = "0x2002F39")]
  public class ReqGuildRaidBtlLog : WebAPI
  {
    [Token(Token = "0x600DB8A")]
    [Address(RVA = "0xA72330", Offset = "0xA71130", VA = "0x10A72330")]
    public ReqGuildRaidBtlLog(
      int gid,
      int page,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002F3A")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E9E3")]
      [FieldOffset(Offset = "0x8")]
      public int gid;
      [Token(Token = "0x400E9E4")]
      [FieldOffset(Offset = "0xC")]
      public int page;

      [Token(Token = "0x600DB8B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F3B")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E9E5")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GuildRaidBattleLog[] battle_logs;

      [Token(Token = "0x600DB8C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
