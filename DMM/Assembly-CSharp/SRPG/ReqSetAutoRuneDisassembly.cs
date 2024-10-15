// Decompiled with JetBrains decompiler
// Type: SRPG.ReqSetAutoRuneDisassembly
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
  [Token(Token = "0x2003032")]
  public class ReqSetAutoRuneDisassembly : WebAPI
  {
    [Token(Token = "0x600DC98")]
    [Address(RVA = "0xA7AA30", Offset = "0xA79830", VA = "0x10A7AA30")]
    public ReqSetAutoRuneDisassembly(
      ReqSetAutoRuneDisassembly.RequestParam param,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2003033")]
    [MessagePackObject(true)]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EB95")]
      [FieldOffset(Offset = "0x8")]
      public JSON_Rune_Auto_Disassemble rune_auto_disassemble;

      [Token(Token = "0x600DC99")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003034")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB96")]
      [FieldOffset(Offset = "0x8")]
      public JSON_Rune_Auto_Disassemble rune_auto_disassemble;

      [Token(Token = "0x600DC9A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }

    [Token(Token = "0x2003035")]
    [MessagePackObject(true)]
    [Serializable]
    public class SetAutoRuneDisassemblyResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400EB97")]
      [FieldOffset(Offset = "0x28")]
      public ReqSetAutoRuneDisassembly.Response body;

      [Token(Token = "0x600DC9B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public SetAutoRuneDisassemblyResponse()
      {
      }
    }
  }
}
