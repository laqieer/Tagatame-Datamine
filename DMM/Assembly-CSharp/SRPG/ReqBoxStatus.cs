// Decompiled with JetBrains decompiler
// Type: SRPG.ReqBoxStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20031FA")]
  public class ReqBoxStatus : WebAPI
  {
    [Token(Token = "0x600DE96")]
    [Address(RVA = "0xA94580", Offset = "0xA93380", VA = "0x10A94580")]
    public ReqBoxStatus(string box_iname, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x20031FB")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EDC9")]
      [FieldOffset(Offset = "0x8")]
      public string box_iname;

      [Token(Token = "0x600DE97")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x20031FC")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EDCA")]
      [FieldOffset(Offset = "0x8")]
      public string box_iname;
      [Token(Token = "0x400EDCB")]
      [FieldOffset(Offset = "0xC")]
      public int step;
      [Token(Token = "0x400EDCC")]
      [FieldOffset(Offset = "0x10")]
      public int total_num;
      [Token(Token = "0x400EDCD")]
      [FieldOffset(Offset = "0x14")]
      public int remain_num;
      [Token(Token = "0x400EDCE")]
      [FieldOffset(Offset = "0x18")]
      public int is_reset_enable;
      [Token(Token = "0x400EDCF")]
      [FieldOffset(Offset = "0x1C")]
      public JSON_BoxGachaCost cost;

      [Token(Token = "0x600DE98")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
