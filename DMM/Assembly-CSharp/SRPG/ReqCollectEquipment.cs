// Decompiled with JetBrains decompiler
// Type: SRPG.ReqCollectEquipment
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
  [Token(Token = "0x2002EE6")]
  public class ReqCollectEquipment : WebAPI
  {
    [Token(Token = "0x600DB32")]
    [Address(RVA = "0xA6DCE0", Offset = "0xA6CAE0", VA = "0x10A6DCE0")]
    public ReqCollectEquipment(
      ReqCollectEquipment.RequestParam param,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002EE7")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E951")]
      [FieldOffset(Offset = "0x8")]
      public int is_concept;
      [Token(Token = "0x400E952")]
      [FieldOffset(Offset = "0x10")]
      public long concept_last_iid;
      [Token(Token = "0x400E953")]
      [FieldOffset(Offset = "0x18")]
      public int is_rune;
      [Token(Token = "0x400E954")]
      [FieldOffset(Offset = "0x20")]
      public long rune_last_iid;
      [Token(Token = "0x400E955")]
      [FieldOffset(Offset = "0x28")]
      public int is_crystal;
      [Token(Token = "0x400E956")]
      [FieldOffset(Offset = "0x30")]
      public long crystal_last_iid;

      [Token(Token = "0x600DB33")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002EE8")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E957")]
      [FieldOffset(Offset = "0x8")]
      public JSON_ConceptCard[] cards;
      [Token(Token = "0x400E958")]
      [FieldOffset(Offset = "0xC")]
      public JSON_ConceptCardMaterial[] materials;
      [Token(Token = "0x400E959")]
      [FieldOffset(Offset = "0x10")]
      public Json_RuneData[] runes;
      [Token(Token = "0x400E95A")]
      [FieldOffset(Offset = "0x14")]
      public Json_RuneEnforceGaugeData[] rune_enforce_gauge;
      [Token(Token = "0x400E95B")]
      [FieldOffset(Offset = "0x18")]
      public int rune_storage;
      [Token(Token = "0x400E95C")]
      [FieldOffset(Offset = "0x1C")]
      public int rune_storage_used;
      [Token(Token = "0x400E95D")]
      [FieldOffset(Offset = "0x20")]
      public JSON_CrystalData[] crystals;

      [Token(Token = "0x600DB34")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }

    [Token(Token = "0x2002EE9")]
    [MessagePackObject(true)]
    [Serializable]
    public class ReqCollectEquipmentResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400E95E")]
      [FieldOffset(Offset = "0x28")]
      public ReqCollectEquipment.Response body;

      [Token(Token = "0x600DB35")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ReqCollectEquipmentResponse()
      {
      }
    }
  }
}
