// Decompiled with JetBrains decompiler
// Type: SRPG.ReqAdventureTimeReduce
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
  [Token(Token = "0x2002E51")]
  public class ReqAdventureTimeReduce : WebAPI
  {
    [Token(Token = "0x600DA95")]
    [Address(RVA = "0xA6B8F0", Offset = "0xA6A6F0", VA = "0x10A6B8F0")]
    public ReqAdventureTimeReduce(
      ReqAdventureTimeReduce.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002E52")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E871")]
      [FieldOffset(Offset = "0x8")]
      public string area_iname;
      [Token(Token = "0x400E872")]
      [FieldOffset(Offset = "0xC")]
      public ReqAdventureTimeReduce.RequestParam.Data[] materials;

      [Token(Token = "0x600DA96")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x2002E53")]
      [Serializable]
      public class Data
      {
        [Token(Token = "0x400E873")]
        [FieldOffset(Offset = "0x8")]
        public string item_iname;
        [Token(Token = "0x400E874")]
        [FieldOffset(Offset = "0xC")]
        public int num;
        [Token(Token = "0x400E875")]
        [FieldOffset(Offset = "0x10")]
        public int current;

        [Token(Token = "0x600DA97")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Data()
        {
        }
      }
    }

    [Token(Token = "0x2002E54")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E876")]
      [FieldOffset(Offset = "0x8")]
      public JSON_AdventureData[] adventure_areas;
      [Token(Token = "0x400E877")]
      [FieldOffset(Offset = "0xC")]
      public Json_Item[] items;

      [Token(Token = "0x600DA98")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
