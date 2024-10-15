// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRankMatchStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003127")]
  public class ReqRankMatchStart : WebAPI
  {
    [Token(Token = "0x600DDBC")]
    [Address(RVA = "0xA8AD80", Offset = "0xA89B80", VA = "0x10A8AD80")]
    public ReqRankMatchStart(Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003128")]
    [Serializable]
    public class EnableTimeSchedule
    {
      [Token(Token = "0x400ECB2")]
      [FieldOffset(Offset = "0x8")]
      public long expired;
      [Token(Token = "0x400ECB3")]
      [FieldOffset(Offset = "0x10")]
      public long next;
      [Token(Token = "0x400ECB4")]
      [FieldOffset(Offset = "0x18")]
      public string iname;

      [Token(Token = "0x600DDBD")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public EnableTimeSchedule()
      {
      }
    }

    [Token(Token = "0x2003129")]
    [Serializable]
    public class StreakWin
    {
      [Token(Token = "0x400ECB5")]
      [FieldOffset(Offset = "0x8")]
      public int num;
      [Token(Token = "0x400ECB6")]
      [FieldOffset(Offset = "0xC")]
      public int best;

      [Token(Token = "0x600DDBE")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public StreakWin()
      {
      }
    }

    [Token(Token = "0x200312A")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400ECB7")]
      [FieldOffset(Offset = "0x8")]
      public string app_id;
      [Token(Token = "0x400ECB8")]
      [FieldOffset(Offset = "0xC")]
      public int schedule_id;
      [Token(Token = "0x400ECB9")]
      [FieldOffset(Offset = "0x10")]
      public int rank;
      [Token(Token = "0x400ECBA")]
      [FieldOffset(Offset = "0x14")]
      public int score;
      [Token(Token = "0x400ECBB")]
      [FieldOffset(Offset = "0x18")]
      public int type;
      [Token(Token = "0x400ECBC")]
      [FieldOffset(Offset = "0x1C")]
      public int bp;
      [Token(Token = "0x400ECBD")]
      [FieldOffset(Offset = "0x20")]
      public ReqRankMatchStart.EnableTimeSchedule enabletime;
      [Token(Token = "0x400ECBE")]
      [FieldOffset(Offset = "0x24")]
      public string[] enemies;
      [Token(Token = "0x400ECBF")]
      [FieldOffset(Offset = "0x28")]
      public ReqRankMatchStart.StreakWin streakwin;
      [Token(Token = "0x400ECC0")]
      [FieldOffset(Offset = "0x2C")]
      public int wincnt;
      [Token(Token = "0x400ECC1")]
      [FieldOffset(Offset = "0x30")]
      public int losecnt;
      [Token(Token = "0x400ECC2")]
      [FieldOffset(Offset = "0x34")]
      public string btl_ver;

      [Token(Token = "0x600DDBF")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
