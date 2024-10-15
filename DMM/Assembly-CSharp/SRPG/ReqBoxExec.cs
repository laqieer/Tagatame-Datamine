// Decompiled with JetBrains decompiler
// Type: SRPG.ReqBoxExec
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20031FD")]
  public class ReqBoxExec : WebAPI
  {
    [Token(Token = "0x600DE99")]
    [Address(RVA = "0xA942E0", Offset = "0xA930E0", VA = "0x10A942E0")]
    public ReqBoxExec(string box_iname, int lottery_num, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x20031FE")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EDD0")]
      [FieldOffset(Offset = "0x8")]
      public string box_iname;
      [Token(Token = "0x400EDD1")]
      [FieldOffset(Offset = "0xC")]
      public int lottery_num;

      [Token(Token = "0x600DE9A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x20031FF")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EDD2")]
      [FieldOffset(Offset = "0x8")]
      public string box_iname;
      [Token(Token = "0x400EDD3")]
      [FieldOffset(Offset = "0xC")]
      public int step;
      [Token(Token = "0x400EDD4")]
      [FieldOffset(Offset = "0x10")]
      public int total_num;
      [Token(Token = "0x400EDD5")]
      [FieldOffset(Offset = "0x14")]
      public int remain_num;
      [Token(Token = "0x400EDD6")]
      [FieldOffset(Offset = "0x18")]
      public int is_reset_enable;
      [Token(Token = "0x400EDD7")]
      [FieldOffset(Offset = "0x1C")]
      public Json_GachaReceipt receipt;
      [Token(Token = "0x400EDD8")]
      [FieldOffset(Offset = "0x20")]
      public Json_DropInfo[] add;
      [Token(Token = "0x400EDD9")]
      [FieldOffset(Offset = "0x24")]
      public Json_DropInfo[] add_mail;
      [Token(Token = "0x400EDDA")]
      [FieldOffset(Offset = "0x28")]
      public Json_PlayerData player;
      [Token(Token = "0x400EDDB")]
      [FieldOffset(Offset = "0x2C")]
      public Json_Item[] items;
      [Token(Token = "0x400EDDC")]
      [FieldOffset(Offset = "0x30")]
      public Json_Unit[] units;
      [Token(Token = "0x400EDDD")]
      [FieldOffset(Offset = "0x34")]
      public Json_Artifact[] artifacts;
      [Token(Token = "0x400EDDE")]
      [FieldOffset(Offset = "0x38")]
      public JSON_TrophyProgress[] trophyprogs;
      [Token(Token = "0x400EDDF")]
      [FieldOffset(Offset = "0x3C")]
      public JSON_TrophyProgress[] bingoprogs;

      [Token(Token = "0x600DE9B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
