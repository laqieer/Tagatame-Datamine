﻿// Decompiled with JetBrains decompiler
// Type: SRPG.ReqCrystalReleaseAllParty
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
  [Token(Token = "0x2002EC7")]
  public class ReqCrystalReleaseAllParty : WebAPI
  {
    [Token(Token = "0x600DB13")]
    [Address(RVA = "0xA6E970", Offset = "0xA6D770", VA = "0x10A6E970")]
    public ReqCrystalReleaseAllParty(
      long _crystal_id,
      string[] _ptypes,
      int _is_cmn,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002EC8")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E902")]
      [FieldOffset(Offset = "0x8")]
      public long crystal_id;
      [Token(Token = "0x400E903")]
      [FieldOffset(Offset = "0x10")]
      public string[] ptypes;
      [Token(Token = "0x400E904")]
      [FieldOffset(Offset = "0x14")]
      public int is_cmn;

      [Token(Token = "0x600DB14")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002EC9")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E905")]
      [FieldOffset(Offset = "0x8")]
      public JSON_PartyOverWrite[] party_decks;
      [Token(Token = "0x400E906")]
      [FieldOffset(Offset = "0xC")]
      public Json_DifferenceUpdate difference_update;

      [Token(Token = "0x600DB15")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}