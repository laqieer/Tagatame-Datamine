// Decompiled with JetBrains decompiler
// Type: SRPG.ReqInspSkillLvUp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002E66")]
  public class ReqInspSkillLvUp : WebAPI
  {
    [Token(Token = "0x600DAAC")]
    [Address(RVA = "0xA75330", Offset = "0xA74130", VA = "0x10A75330")]
    public ReqInspSkillLvUp(
      long artifact_iid,
      long inspiration_skil_iid,
      long[] mix_iids,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002E67")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E886")]
      [FieldOffset(Offset = "0x8")]
      public long artifact_iid;
      [Token(Token = "0x400E887")]
      [FieldOffset(Offset = "0x10")]
      public long inspiration_skil_iid;
      [Token(Token = "0x400E888")]
      [FieldOffset(Offset = "0x18")]
      public long[] mix_iids;

      [Token(Token = "0x600DAAD")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002E68")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E889")]
      [FieldOffset(Offset = "0x8")]
      public Json_InspirationSkill inspiration_skill;
      [Token(Token = "0x400E88A")]
      [FieldOffset(Offset = "0xC")]
      public Json_PlayerData player;
      [Token(Token = "0x400E88B")]
      [FieldOffset(Offset = "0x10")]
      public long[] mix_iids;

      [Token(Token = "0x600DAAE")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
