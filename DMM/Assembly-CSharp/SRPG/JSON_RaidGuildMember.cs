// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RaidGuildMember
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F85")]
  [Serializable]
  public class JSON_RaidGuildMember : JSON_GuildMember
  {
    [Token(Token = "0x4003686")]
    [FieldOffset(Offset = "0x50")]
    public int beat_score;
    [Token(Token = "0x4003687")]
    [FieldOffset(Offset = "0x54")]
    public int rescue_score;
    [Token(Token = "0x4003688")]
    [FieldOffset(Offset = "0x58")]
    public int round;
    [Token(Token = "0x4003689")]
    [FieldOffset(Offset = "0x5C")]
    public Json_Unit unit;
    [Token(Token = "0x400368A")]
    [FieldOffset(Offset = "0x60")]
    public string selected_award;

    [Token(Token = "0x6004059")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RaidGuildMember()
    {
    }
  }
}
