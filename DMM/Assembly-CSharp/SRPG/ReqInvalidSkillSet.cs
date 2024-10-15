// Decompiled with JetBrains decompiler
// Type: SRPG.ReqInvalidSkillSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200329F")]
  public class ReqInvalidSkillSet : WebAPI
  {
    [Token(Token = "0x600DF41")]
    [Address(RVA = "0xA9A540", Offset = "0xA99340", VA = "0x10A9A540")]
    public ReqInvalidSkillSet(
      long _unit_iid,
      int apply_type,
      List<InvalidSkill> _invalid_skills,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x20032A0")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EF29")]
      [FieldOffset(Offset = "0x8")]
      public long unit_iid;
      [Token(Token = "0x400EF2A")]
      [FieldOffset(Offset = "0x10")]
      public int apply_type;
      [Token(Token = "0x400EF2B")]
      [FieldOffset(Offset = "0x14")]
      public Json_InvalidSkillData[] skills;

      [Token(Token = "0x600DF42")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x20032A1")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF2C")]
      [FieldOffset(Offset = "0x8")]
      public long iid;
      [Token(Token = "0x400EF2D")]
      [FieldOffset(Offset = "0x10")]
      public Json_InvalidSkillApplyType[] invalid_skills;

      [Token(Token = "0x600DF43")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
