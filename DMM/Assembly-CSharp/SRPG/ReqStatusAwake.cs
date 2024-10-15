// Decompiled with JetBrains decompiler
// Type: SRPG.ReqStatusAwake
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
  [Token(Token = "0x200303F")]
  public class ReqStatusAwake : WebAPI
  {
    [Token(Token = "0x600DCA5")]
    [Address(RVA = "0xA7BA00", Offset = "0xA7A800", VA = "0x10A7BA00")]
    public ReqStatusAwake(
      ReqStatusAwake.RequestParam req,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2003040")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EB9E")]
      [FieldOffset(Offset = "0x8")]
      public long unit_id;
      [Token(Token = "0x400EB9F")]
      [FieldOffset(Offset = "0x10")]
      public ReqStatusAwake.RequestParam.MaterialData[] materials;

      [Token(Token = "0x600DCA6")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x2003041")]
      [Serializable]
      public class MaterialData
      {
        [Token(Token = "0x400EBA0")]
        [FieldOffset(Offset = "0x8")]
        public string iname;
        [Token(Token = "0x400EBA1")]
        [FieldOffset(Offset = "0xC")]
        public int num;
        [Token(Token = "0x400EBA2")]
        [FieldOffset(Offset = "0x10")]
        public int current;

        [Token(Token = "0x600DCA7")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public MaterialData()
        {
        }
      }
    }

    [Token(Token = "0x2003042")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EBA3")]
      [FieldOffset(Offset = "0x8")]
      public Json_DifferenceUpdatePlayer difference_update;
      [Token(Token = "0x400EBA4")]
      [FieldOffset(Offset = "0xC")]
      public Json_StatusAwakeData[] used_items;

      [Token(Token = "0x600DCA8")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }

    [Token(Token = "0x2003043")]
    [MessagePackObject(true)]
    [Serializable]
    public class StatusAwakeResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400EBA5")]
      [FieldOffset(Offset = "0x28")]
      public ReqStatusAwake.Response body;

      [Token(Token = "0x600DCA9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public StatusAwakeResponse()
      {
      }
    }
  }
}
