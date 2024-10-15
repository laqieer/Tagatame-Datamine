// Decompiled with JetBrains decompiler
// Type: SRPG.ReqInvalidSkillSetList
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
  [Token(Token = "0x2002FA6")]
  public class ReqInvalidSkillSetList : WebAPI
  {
    [Token(Token = "0x600DBFA")]
    [Address(RVA = "0xA75560", Offset = "0xA74360", VA = "0x10A75560")]
    public ReqInvalidSkillSetList(
      ReqInvalidSkillSetList.RequestParam param,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002FA7")]
    [MessagePackObject(true)]
    [Serializable]
    public class RequestSetUnitList
    {
      [Token(Token = "0x400EA80")]
      [FieldOffset(Offset = "0x8")]
      public long unit_iid;
      [Token(Token = "0x400EA81")]
      [FieldOffset(Offset = "0x10")]
      public Json_InvalidSkillData[] skills;

      [Token(Token = "0x600DBFB")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestSetUnitList()
      {
      }
    }

    [Token(Token = "0x2002FA8")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EA82")]
      [FieldOffset(Offset = "0x8")]
      public int apply_type;
      [Token(Token = "0x400EA83")]
      [FieldOffset(Offset = "0xC")]
      public ReqInvalidSkillSetList.RequestSetUnitList[] units;

      [Token(Token = "0x600DBFC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002FA9")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA84")]
      [FieldOffset(Offset = "0x8")]
      public ReqInvalidSkillSet.Response[] invalid_units;

      [Token(Token = "0x600DBFD")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }

    [Token(Token = "0x2002FAA")]
    [MessagePackObject(true)]
    [Serializable]
    public class ReqInvalidSkillSetListResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400EA85")]
      [FieldOffset(Offset = "0x28")]
      public ReqInvalidSkillSetList.Response body;

      [Token(Token = "0x600DBFE")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ReqInvalidSkillSetListResponse()
      {
      }
    }
  }
}
