// Decompiled with JetBrains decompiler
// Type: SRPG.ReqArtifact
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002E63")]
  public class ReqArtifact : WebAPI
  {
    [Token(Token = "0x600DAA9")]
    [Address(RVA = "0xA6D2A0", Offset = "0xA6C0A0", VA = "0x10A6D2A0")]
    public ReqArtifact(long last_artifact_iid, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002E64")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E884")]
      [FieldOffset(Offset = "0x8")]
      public long last_iid;

      [Token(Token = "0x600DAAA")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002E65")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E885")]
      [FieldOffset(Offset = "0x8")]
      public Json_Artifact[] artifacts;

      [Token(Token = "0x600DAAB")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
