// Decompiled with JetBrains decompiler
// Type: SRPG.ReqInspSkillReset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002E69")]
  public class ReqInspSkillReset : WebAPI
  {
    [Token(Token = "0x600DAAF")]
    [Address(RVA = "0xA75450", Offset = "0xA74250", VA = "0x10A75450")]
    public ReqInspSkillReset(
      long artifact_iid,
      long inspiration_skil_iid,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002E6A")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E88C")]
      [FieldOffset(Offset = "0x8")]
      public long artifact_iid;
      [Token(Token = "0x400E88D")]
      [FieldOffset(Offset = "0x10")]
      public long inspiration_skil_iid;

      [Token(Token = "0x600DAB0")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002E6B")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E88E")]
      [FieldOffset(Offset = "0x8")]
      public Json_InspirationSkill inspiration_skill;
      [Token(Token = "0x400E88F")]
      [FieldOffset(Offset = "0xC")]
      public Json_PlayerData player;

      [Token(Token = "0x600DAB1")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
