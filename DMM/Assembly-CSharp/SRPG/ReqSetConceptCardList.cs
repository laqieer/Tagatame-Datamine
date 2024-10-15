// Decompiled with JetBrains decompiler
// Type: SRPG.ReqSetConceptCardList
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
  [Token(Token = "0x2002EA7")]
  public class ReqSetConceptCardList : WebAPI
  {
    [Token(Token = "0x600DAF1")]
    [Address(RVA = "0xA7AED0", Offset = "0xA79CD0", VA = "0x10A7AED0")]
    public ReqSetConceptCardList(
      Dictionary<long, long> req_set_list,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x600DAF2")]
    [Address(RVA = "0xA7AE40", Offset = "0xA79C40", VA = "0x10A7AE40")]
    public ReqSetConceptCardList(
      List<KeyValuePair<long, long>> req_set_list,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x600DAF3")]
    [Address(RVA = "0xA7AB00", Offset = "0xA79900", VA = "0x10A7AB00")]
    private void Initialize(
      List<KeyValuePair<long, long>> req_set_list,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002EA8")]
    [Serializable]
    public class RequestSetList
    {
      [Token(Token = "0x400E8D6")]
      [FieldOffset(Offset = "0x8")]
      public long concept_iid;
      [Token(Token = "0x400E8D7")]
      [FieldOffset(Offset = "0x10")]
      public long unit_iid;

      [Token(Token = "0x600DAF4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestSetList()
      {
      }
    }

    [Token(Token = "0x2002EA9")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E8D8")]
      [FieldOffset(Offset = "0x8")]
      public ReqSetConceptCardList.RequestSetList[] set_list;

      [Token(Token = "0x600DAF5")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002EAA")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E8D9")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x400E8DA")]
      [FieldOffset(Offset = "0xC")]
      public Json_Unit[] units;

      [Token(Token = "0x600DAF6")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
