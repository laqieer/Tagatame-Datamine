// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildRaidReport
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FA4")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuildRaidReport
  {
    [Token(Token = "0x4003712")]
    [FieldOffset(Offset = "0x8")]
    public int report_id;
    [Token(Token = "0x4003713")]
    [FieldOffset(Offset = "0xC")]
    public int boss_id;
    [Token(Token = "0x4003714")]
    [FieldOffset(Offset = "0x10")]
    public int round;
    [Token(Token = "0x4003715")]
    [FieldOffset(Offset = "0x14")]
    public int damage;
    [Token(Token = "0x4003716")]
    [FieldOffset(Offset = "0x18")]
    public int posted_at;
    [Token(Token = "0x4003717")]
    [FieldOffset(Offset = "0x1C")]
    public JSON_GuildRaidDeck deck;

    [Token(Token = "0x60040CE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildRaidReport()
    {
    }
  }
}
