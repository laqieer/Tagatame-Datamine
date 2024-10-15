// Decompiled with JetBrains decompiler
// Type: SRPG.ReqVersusDraftSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003053")]
  public class ReqVersusDraftSelect : WebAPI
  {
    [Token(Token = "0x600DCB8")]
    [Address(RVA = "0xA7C740", Offset = "0xA7B540", VA = "0x10A7C740")]
    public ReqVersusDraftSelect(string token, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003054")]
    [Serializable]
    public class RequestDraftUnit
    {
      [Token(Token = "0x400EBBA")]
      [FieldOffset(Offset = "0x8")]
      public long id;
      [Token(Token = "0x400EBBB")]
      [FieldOffset(Offset = "0x10")]
      public int secret;

      [Token(Token = "0x600DCB9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestDraftUnit()
      {
      }
    }

    [Token(Token = "0x2003055")]
    [Serializable]
    public class RequestDraftResult
    {
      [Token(Token = "0x400EBBC")]
      [FieldOffset(Offset = "0x8")]
      public int turn_own;
      [Token(Token = "0x400EBBD")]
      [FieldOffset(Offset = "0xC")]
      public ReqVersusDraftSelect.RequestDraftUnit[] draft_units;

      [Token(Token = "0x600DCBA")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestDraftResult()
      {
      }
    }

    [Token(Token = "0x2003056")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EBBE")]
      [FieldOffset(Offset = "0x8")]
      public string token;
      [Token(Token = "0x400EBBF")]
      [FieldOffset(Offset = "0xC")]
      public ReqVersusDraftSelect.RequestDraftResult draft_result;

      [Token(Token = "0x600DCBB")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003057")]
    public class Response
    {
      [Token(Token = "0x400EBC0")]
      [FieldOffset(Offset = "0x8")]
      public int draft_id;

      [Token(Token = "0x600DCBC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
