// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildTrainingCampaign
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B38")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuildTrainingCampaign
  {
    [Token(Token = "0x40067A5")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x40067A6")]
    [FieldOffset(Offset = "0xC")]
    public string begin_at;
    [Token(Token = "0x40067A7")]
    [FieldOffset(Offset = "0x10")]
    public string end_at;
    [Token(Token = "0x40067A8")]
    [FieldOffset(Offset = "0x14")]
    public int time_rate;
    [Token(Token = "0x40067A9")]
    [FieldOffset(Offset = "0x18")]
    public int drop_rate;
    [Token(Token = "0x40067AA")]
    [FieldOffset(Offset = "0x1C")]
    public string[] unit_group_inames;
    [Token(Token = "0x40067AB")]
    [FieldOffset(Offset = "0x20")]
    public string[] unit_inames;

    [Token(Token = "0x6007029")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildTrainingCampaign()
    {
    }
  }
}
