// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRuneDedicated
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
  [Token(Token = "0x2003029")]
  public class ReqRuneDedicated : WebAPI
  {
    [Token(Token = "0x600DC8C")]
    [Address(RVA = "0xA79DC0", Offset = "0xA78BC0", VA = "0x10A79DC0")]
    public ReqRuneDedicated(
      ReqRuneDedicated.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x200302A")]
    [MessagePackObject(true)]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EB8B")]
      [FieldOffset(Offset = "0x8")]
      public long unit_id;
      [Token(Token = "0x400EB8C")]
      [FieldOffset(Offset = "0x10")]
      public long rune_id;

      [Token(Token = "0x600DC8D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x600DC8E")]
      [Address(RVA = "0xA7DD00", Offset = "0xA7CB00", VA = "0x10A7DD00")]
      public RequestParam(long unitId, long runeId)
      {
      }
    }

    [Token(Token = "0x200302B")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB8D")]
      [FieldOffset(Offset = "0x8")]
      public Json_DifferenceUpdate difference_update;
      [Token(Token = "0x400EB8E")]
      [FieldOffset(Offset = "0xC")]
      public Json_PlayerData player;

      [Token(Token = "0x600DC8F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
