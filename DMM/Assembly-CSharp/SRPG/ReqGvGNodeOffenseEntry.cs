// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGvGNodeOffenseEntry
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
  [Token(Token = "0x2003266")]
  public class ReqGvGNodeOffenseEntry : WebAPI
  {
    [Token(Token = "0x600DF07")]
    [Address(RVA = "0xA99A60", Offset = "0xA98860", VA = "0x10A99A60")]
    public ReqGvGNodeOffenseEntry(
      int id,
      int gid,
      int gvg_group_id,
      int is_force,
      List<JSON_GvGUnitOverWriteData> party,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003267")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EEB7")]
      [FieldOffset(Offset = "0x8")]
      public int id;
      [Token(Token = "0x400EEB8")]
      [FieldOffset(Offset = "0xC")]
      public int gid;
      [Token(Token = "0x400EEB9")]
      [FieldOffset(Offset = "0x10")]
      public int gvg_group_id;
      [Token(Token = "0x400EEBA")]
      [FieldOffset(Offset = "0x14")]
      public List<JSON_GvGUnitOverWriteData> party;
      [Token(Token = "0x400EEBB")]
      [FieldOffset(Offset = "0x18")]
      public int is_force;

      [Token(Token = "0x600DF08")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003268")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EEBC")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GvGPartyUnit[] offense;
      [Token(Token = "0x400EEBD")]
      [FieldOffset(Offset = "0xC")]
      public JSON_GvGUsedItems[] unavailable_items;
      [Token(Token = "0x400EEBE")]
      [FieldOffset(Offset = "0x10")]
      public JSON_PlayerBuff player_buff;

      [Token(Token = "0x600DF09")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
