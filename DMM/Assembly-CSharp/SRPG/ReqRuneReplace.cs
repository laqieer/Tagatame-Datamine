// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRuneReplace
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
  [Token(Token = "0x200302F")]
  public class ReqRuneReplace : WebAPI
  {
    [Token(Token = "0x600DC94")]
    [Address(RVA = "0xA7A440", Offset = "0xA79240", VA = "0x10A7A440")]
    public ReqRuneReplace(
      long uid,
      long ruid,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2003030")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EB92")]
      [FieldOffset(Offset = "0x8")]
      public long unit_id;
      [Token(Token = "0x400EB93")]
      [FieldOffset(Offset = "0x10")]
      public long replace_unit_id;

      [Token(Token = "0x600DC95")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x600DC96")]
      [Address(RVA = "0xA7DD00", Offset = "0xA7CB00", VA = "0x10A7DD00")]
      public RequestParam(long _unit_id, long _replace_unit_id)
      {
      }
    }

    [Token(Token = "0x2003031")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB94")]
      [FieldOffset(Offset = "0x8")]
      public Json_DifferenceUpdate difference_update;

      [Token(Token = "0x600DC97")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
