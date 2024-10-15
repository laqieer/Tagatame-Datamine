// Decompiled with JetBrains decompiler
// Type: SRPG.ReqOverWriteSetList
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
  [Token(Token = "0x2002F9F")]
  public class ReqOverWriteSetList : WebAPI
  {
    [Token(Token = "0x600DBF2")]
    [Address(RVA = "0xA775D0", Offset = "0xA763D0", VA = "0x10A775D0")]
    public ReqOverWriteSetList(
      ReqOverWriteSetList.RequestParam param,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x600DBF3")]
    [Address(RVA = "0xA776A0", Offset = "0xA764A0", VA = "0x10A776A0")]
    public ReqOverWriteSetList(
      ReqOverWriteSetList.RequestParamNotRune param,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002FA0")]
    [MessagePackObject(true)]
    [Serializable]
    public class RequestSetUnitList : ReqOverWriteSetList.RequestSetUnitBaseList
    {
      [Token(Token = "0x400EA72")]
      [FieldOffset(Offset = "0x30")]
      public long[] rune_iids;

      [Token(Token = "0x600DBF4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestSetUnitList()
      {
      }
    }

    [Token(Token = "0x2002FA1")]
    [MessagePackObject(true)]
    [Serializable]
    public class RequestSetUnitBaseList
    {
      [Token(Token = "0x400EA73")]
      [FieldOffset(Offset = "0x8")]
      public long unit_iid;
      [Token(Token = "0x400EA74")]
      [FieldOffset(Offset = "0x10")]
      public long job_iid;
      [Token(Token = "0x400EA75")]
      [FieldOffset(Offset = "0x18")]
      public long[] abil_iids;
      [Token(Token = "0x400EA76")]
      [FieldOffset(Offset = "0x1C")]
      public JSON_CrystalUnitSetReq[] crystals;
      [Token(Token = "0x400EA77")]
      [FieldOffset(Offset = "0x20")]
      public long[] concept_iids;
      [Token(Token = "0x400EA78")]
      [FieldOffset(Offset = "0x24")]
      public long[] artifact_iids;
      [Token(Token = "0x400EA79")]
      [FieldOffset(Offset = "0x28")]
      public int reader_skill_set;

      [Token(Token = "0x600DBF5")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestSetUnitBaseList()
      {
      }
    }

    [Token(Token = "0x2002FA2")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EA7A")]
      [FieldOffset(Offset = "0x8")]
      public ReqOverWriteSetList.RequestSetUnitList[] units;
      [Token(Token = "0x400EA7B")]
      [FieldOffset(Offset = "0xC")]
      public string ptype;

      [Token(Token = "0x600DBF6")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002FA3")]
    [Serializable]
    public class RequestParamNotRune
    {
      [Token(Token = "0x400EA7C")]
      [FieldOffset(Offset = "0x8")]
      public ReqOverWriteSetList.RequestSetUnitBaseList[] units;
      [Token(Token = "0x400EA7D")]
      [FieldOffset(Offset = "0xC")]
      public string ptype;

      [Token(Token = "0x600DBF7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParamNotRune()
      {
      }
    }

    [Token(Token = "0x2002FA4")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA7E")]
      [FieldOffset(Offset = "0x8")]
      public JSON_PartyOverWrite[] party_decks;

      [Token(Token = "0x600DBF8")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }

    [Token(Token = "0x2002FA5")]
    [MessagePackObject(true)]
    [Serializable]
    public class ReqOverWriteSetListResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400EA7F")]
      [FieldOffset(Offset = "0x28")]
      public ReqOverWriteSetList.Response body;

      [Token(Token = "0x600DBF9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ReqOverWriteSetListResponse()
      {
      }
    }
  }
}
