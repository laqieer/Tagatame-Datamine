// Decompiled with JetBrains decompiler
// Type: SRPG.ReqDuelBattleResume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002EDD")]
  public class ReqDuelBattleResume : WebAPI
  {
    [Token(Token = "0x600DB29")]
    [Address(RVA = "0xA6F5A0", Offset = "0xA6E3A0", VA = "0x10A6F5A0")]
    public ReqDuelBattleResume(long btlid, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002EDE")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E929")]
      [FieldOffset(Offset = "0x8")]
      public long btlid;

      [Token(Token = "0x600DB2A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002EDF")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E92A")]
      [FieldOffset(Offset = "0x8")]
      public long btlid;
      [Token(Token = "0x400E92B")]
      [FieldOffset(Offset = "0x10")]
      public BattleCore.Json_BtlInfo btlinfo;
      [Token(Token = "0x400E92C")]
      [FieldOffset(Offset = "0x14")]
      public int maxActionNum;

      [Token(Token = "0x600DB2B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
