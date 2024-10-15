// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRaidInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002FC4")]
  public class ReqRaidInfo : WebAPI
  {
    [Token(Token = "0x600DC18")]
    [Address(RVA = "0xA78BC0", Offset = "0xA779C0", VA = "0x10A78BC0")]
    public ReqRaidInfo(
      int area_id,
      int boss_id,
      int round,
      string uid,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002FC5")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EACA")]
      [FieldOffset(Offset = "0x8")]
      public int area_id;
      [Token(Token = "0x400EACB")]
      [FieldOffset(Offset = "0xC")]
      public int boss_id;
      [Token(Token = "0x400EACC")]
      [FieldOffset(Offset = "0x10")]
      public int round;
      [Token(Token = "0x400EACD")]
      [FieldOffset(Offset = "0x14")]
      public string uid;

      [Token(Token = "0x600DC19")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002FC6")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EACE")]
      [FieldOffset(Offset = "0x8")]
      public int able_challenge_count;
      [Token(Token = "0x400EACF")]
      [FieldOffset(Offset = "0xC")]
      public JSON_RaidBossData raidboss;

      [Token(Token = "0x600DC1A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
