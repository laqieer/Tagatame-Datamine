// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRuneResetDedicated
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
  [Token(Token = "0x200302C")]
  public class ReqRuneResetDedicated : WebAPI
  {
    [Token(Token = "0x600DC90")]
    [Address(RVA = "0xA7A560", Offset = "0xA79360", VA = "0x10A7A560")]
    public ReqRuneResetDedicated(
      ReqRuneResetDedicated.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x200302D")]
    [MessagePackObject(true)]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EB8F")]
      [FieldOffset(Offset = "0x8")]
      public long rune_id;

      [Token(Token = "0x600DC91")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x600DC92")]
      [Address(RVA = "0xA7DDA0", Offset = "0xA7CBA0", VA = "0x10A7DDA0")]
      public RequestParam(long runeId)
      {
      }
    }

    [Token(Token = "0x200302E")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB90")]
      [FieldOffset(Offset = "0x8")]
      public Json_DifferenceUpdate difference_update;
      [Token(Token = "0x400EB91")]
      [FieldOffset(Offset = "0xC")]
      public Json_PlayerData player;

      [Token(Token = "0x600DC93")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
