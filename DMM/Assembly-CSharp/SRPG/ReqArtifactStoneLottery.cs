// Decompiled with JetBrains decompiler
// Type: SRPG.ReqArtifactStoneLottery
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
  [Token(Token = "0x2002E75")]
  public class ReqArtifactStoneLottery : WebAPI
  {
    [Token(Token = "0x600DABB")]
    [Address(RVA = "0xA6CFE0", Offset = "0xA6BDE0", VA = "0x10A6CFE0")]
    public ReqArtifactStoneLottery(
      long artifact_iid,
      long[] mats,
      int is_cmn,
      string lottery_hold_stone,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002E76")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E89B")]
      [FieldOffset(Offset = "0x8")]
      public long iid;
      [Token(Token = "0x400E89C")]
      [FieldOffset(Offset = "0x10")]
      public long[] mats;
      [Token(Token = "0x400E89D")]
      [FieldOffset(Offset = "0x14")]
      public int is_cmn;
      [Token(Token = "0x400E89E")]
      [FieldOffset(Offset = "0x18")]
      public ReqArtifactStoneLottery.RequestParam_StoneHold stone_on_hold;

      [Token(Token = "0x600DABC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002E77")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E89F")]
      [FieldOffset(Offset = "0x8")]
      public Json_DifferenceUpdatePlayer difference_update;
      [Token(Token = "0x400E8A0")]
      [FieldOffset(Offset = "0xC")]
      public string lottery_artifact_stone_status_iname;
      [Token(Token = "0x400E8A1")]
      [FieldOffset(Offset = "0x10")]
      public long[] iids;

      [Token(Token = "0x600DABD")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }

    [Token(Token = "0x2002E78")]
    [Serializable]
    public class RequestParam_StoneHold
    {
      [Token(Token = "0x400E8A2")]
      [FieldOffset(Offset = "0x8")]
      public long artifact_id;
      [Token(Token = "0x400E8A3")]
      [FieldOffset(Offset = "0x10")]
      public string stone_iname;

      [Token(Token = "0x600DABE")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam_StoneHold()
      {
      }
    }
  }
}
