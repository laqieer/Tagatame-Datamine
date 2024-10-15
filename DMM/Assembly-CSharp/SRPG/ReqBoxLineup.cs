// Decompiled with JetBrains decompiler
// Type: SRPG.ReqBoxLineup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003200")]
  public class ReqBoxLineup : WebAPI
  {
    [Token(Token = "0x600DE9C")]
    [Address(RVA = "0xA943C0", Offset = "0xA931C0", VA = "0x10A943C0")]
    public ReqBoxLineup(string box_iname, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003201")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EDE0")]
      [FieldOffset(Offset = "0x8")]
      public string box_iname;

      [Token(Token = "0x600DE9D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003202")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EDE1")]
      [FieldOffset(Offset = "0x8")]
      public string box_iname;
      [Token(Token = "0x400EDE2")]
      [FieldOffset(Offset = "0xC")]
      public int total_step;
      [Token(Token = "0x400EDE3")]
      [FieldOffset(Offset = "0x10")]
      public JSON_BoxGachaSteps[] steps;

      [Token(Token = "0x600DE9E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
