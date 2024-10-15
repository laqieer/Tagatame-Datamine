// Decompiled with JetBrains decompiler
// Type: SRPG.ReqInspSkillAddSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002E6F")]
  public class ReqInspSkillAddSlot : WebAPI
  {
    [Token(Token = "0x600DAB5")]
    [Address(RVA = "0xA75120", Offset = "0xA73F20", VA = "0x10A75120")]
    public ReqInspSkillAddSlot(long artifact_iid, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002E70")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E893")]
      [FieldOffset(Offset = "0x8")]
      public long artifact_iid;

      [Token(Token = "0x600DAB6")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002E71")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E894")]
      [FieldOffset(Offset = "0x8")]
      public Json_Artifact artifact;
      [Token(Token = "0x400E895")]
      [FieldOffset(Offset = "0xC")]
      public Json_PlayerData player;

      [Token(Token = "0x600DAB7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
