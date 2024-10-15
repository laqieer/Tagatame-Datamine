// Decompiled with JetBrains decompiler
// Type: SRPG.ReqBoxReset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003203")]
  public class ReqBoxReset : WebAPI
  {
    [Token(Token = "0x600DE9F")]
    [Address(RVA = "0xA944A0", Offset = "0xA932A0", VA = "0x10A944A0")]
    public ReqBoxReset(string box_iname, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003204")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EDE4")]
      [FieldOffset(Offset = "0x8")]
      public string box_iname;

      [Token(Token = "0x600DEA0")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003205")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EDE5")]
      [FieldOffset(Offset = "0x8")]
      public string box_iname;
      [Token(Token = "0x400EDE6")]
      [FieldOffset(Offset = "0xC")]
      public int step;
      [Token(Token = "0x400EDE7")]
      [FieldOffset(Offset = "0x10")]
      public int total_num;
      [Token(Token = "0x400EDE8")]
      [FieldOffset(Offset = "0x14")]
      public int remain_num;

      [Token(Token = "0x600DEA1")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
