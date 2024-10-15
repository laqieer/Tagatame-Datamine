// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildRaidMailListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FA0")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuildRaidMailListItem
  {
    [Token(Token = "0x4003705")]
    [FieldOffset(Offset = "0x8")]
    public int mid;
    [Token(Token = "0x4003706")]
    [FieldOffset(Offset = "0xC")]
    public int round;
    [Token(Token = "0x4003707")]
    [FieldOffset(Offset = "0x10")]
    public string msg;
    [Token(Token = "0x4003708")]
    [FieldOffset(Offset = "0x14")]
    public int boss_id;
    [Token(Token = "0x4003709")]
    [FieldOffset(Offset = "0x18")]
    public string reward_id;
    [Token(Token = "0x400370A")]
    [FieldOffset(Offset = "0x1C")]
    public int reward_type;

    [Token(Token = "0x60040CA")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildRaidMailListItem()
    {
    }
  }
}
