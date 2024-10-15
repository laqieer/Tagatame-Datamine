// Decompiled with JetBrains decompiler
// Type: SRPG.ReqArtifactStoneOpen
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
  [Token(Token = "0x2002E72")]
  public class ReqArtifactStoneOpen : WebAPI
  {
    [Token(Token = "0x600DAB8")]
    [Address(RVA = "0xA6D180", Offset = "0xA6BF80", VA = "0x10A6D180")]
    public ReqArtifactStoneOpen(
      long artifact_iid,
      long[] mats,
      int is_cmn,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002E73")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E896")]
      [FieldOffset(Offset = "0x8")]
      public long iid;
      [Token(Token = "0x400E897")]
      [FieldOffset(Offset = "0x10")]
      public long[] mats;
      [Token(Token = "0x400E898")]
      [FieldOffset(Offset = "0x14")]
      public int is_cmn;

      [Token(Token = "0x600DAB9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002E74")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E899")]
      [FieldOffset(Offset = "0x8")]
      public Json_DifferenceUpdatePlayer difference_update;
      [Token(Token = "0x400E89A")]
      [FieldOffset(Offset = "0xC")]
      public long[] iids;

      [Token(Token = "0x600DABA")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
