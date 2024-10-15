// Decompiled with JetBrains decompiler
// Type: SRPG.ReqInvalidSkillGet
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
  [Token(Token = "0x200329C")]
  public class ReqInvalidSkillGet : WebAPI
  {
    [Token(Token = "0x600DF3E")]
    [Address(RVA = "0xA9A460", Offset = "0xA99260", VA = "0x10A9A460")]
    public ReqInvalidSkillGet(
      int _apply_type,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x200329D")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EF27")]
      [FieldOffset(Offset = "0x8")]
      public int apply_type;

      [Token(Token = "0x600DF3F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x200329E")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF28")]
      [FieldOffset(Offset = "0x8")]
      public Json_InvalidSkill[] invalid_units;

      [Token(Token = "0x600DF40")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
