// Decompiled with JetBrains decompiler
// Type: SRPG.ReqArtifactStoneConvert
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
  [Token(Token = "0x2002E7C")]
  public class ReqArtifactStoneConvert : WebAPI
  {
    [Token(Token = "0x600DAC2")]
    [Address(RVA = "0xA6CED0", Offset = "0xA6BCD0", VA = "0x10A6CED0")]
    public ReqArtifactStoneConvert(
      long[] artifact_iids,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002E7D")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E8A7")]
      [FieldOffset(Offset = "0x8")]
      public long[] iids;

      [Token(Token = "0x600DAC3")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002E7E")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E8A8")]
      [FieldOffset(Offset = "0x8")]
      public Json_DifferenceUpdatePlayer difference_update;
      [Token(Token = "0x400E8A9")]
      [FieldOffset(Offset = "0xC")]
      public long[] iids;

      [Token(Token = "0x600DAC4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
