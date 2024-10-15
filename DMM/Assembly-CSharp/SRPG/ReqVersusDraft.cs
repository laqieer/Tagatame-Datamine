// Decompiled with JetBrains decompiler
// Type: SRPG.ReqVersusDraft
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200304F")]
  public class ReqVersusDraft : WebAPI
  {
    [Token(Token = "0x600DCB4")]
    [Address(RVA = "0xA7CC70", Offset = "0xA7BA70", VA = "0x10A7CC70")]
    public ReqVersusDraft(string token, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003050")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EBB5")]
      [FieldOffset(Offset = "0x8")]
      public string token;

      [Token(Token = "0x600DCB5")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003051")]
    public class ResponseUnit
    {
      [Token(Token = "0x400EBB6")]
      [FieldOffset(Offset = "0x8")]
      public long id;
      [Token(Token = "0x400EBB7")]
      [FieldOffset(Offset = "0x10")]
      public int secret;

      [Token(Token = "0x600DCB6")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ResponseUnit()
      {
      }
    }

    [Token(Token = "0x2003052")]
    public class Response
    {
      [Token(Token = "0x400EBB8")]
      [FieldOffset(Offset = "0x8")]
      public int turn_own;
      [Token(Token = "0x400EBB9")]
      [FieldOffset(Offset = "0xC")]
      public ReqVersusDraft.ResponseUnit[] draft_units;

      [Token(Token = "0x600DCB7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
