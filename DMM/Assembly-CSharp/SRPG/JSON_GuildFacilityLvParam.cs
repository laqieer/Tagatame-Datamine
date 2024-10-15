// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildFacilityLvParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B3C")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuildFacilityLvParam
  {
    [Token(Token = "0x40067C2")]
    [FieldOffset(Offset = "0x8")]
    public int lv;
    [Token(Token = "0x40067C3")]
    [FieldOffset(Offset = "0xC")]
    public int base_camp;
    [Token(Token = "0x40067C4")]
    [FieldOffset(Offset = "0x10")]
    public long guild_shop;

    [Token(Token = "0x6007040")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildFacilityLvParam()
    {
    }
  }
}
