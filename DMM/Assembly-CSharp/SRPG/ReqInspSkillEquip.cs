// Decompiled with JetBrains decompiler
// Type: SRPG.ReqInspSkillEquip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002E6C")]
  public class ReqInspSkillEquip : WebAPI
  {
    [Token(Token = "0x600DAB2")]
    [Address(RVA = "0xA75220", Offset = "0xA74020", VA = "0x10A75220")]
    public ReqInspSkillEquip(
      long artifact_iid,
      long inspiration_skil_iid,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002E6D")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E890")]
      [FieldOffset(Offset = "0x8")]
      public long artifact_iid;
      [Token(Token = "0x400E891")]
      [FieldOffset(Offset = "0x10")]
      public long inspiration_skil_iid;

      [Token(Token = "0x600DAB3")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002E6E")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E892")]
      [FieldOffset(Offset = "0x8")]
      public Json_Artifact artifact;

      [Token(Token = "0x600DAB4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
