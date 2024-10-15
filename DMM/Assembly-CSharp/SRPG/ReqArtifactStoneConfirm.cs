// Decompiled with JetBrains decompiler
// Type: SRPG.ReqArtifactStoneConfirm
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
  [Token(Token = "0x2002E79")]
  public class ReqArtifactStoneConfirm : WebAPI
  {
    [Token(Token = "0x600DABF")]
    [Address(RVA = "0xA6CDC0", Offset = "0xA6BBC0", VA = "0x10A6CDC0")]
    public ReqArtifactStoneConfirm(
      long artifact_iid,
      int is_update,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002E7A")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E8A4")]
      [FieldOffset(Offset = "0x8")]
      public long iid;
      [Token(Token = "0x400E8A5")]
      [FieldOffset(Offset = "0x10")]
      public int is_update;

      [Token(Token = "0x600DAC0")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002E7B")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E8A6")]
      [FieldOffset(Offset = "0x8")]
      public Json_DifferenceUpdate difference_update;

      [Token(Token = "0x600DAC1")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
