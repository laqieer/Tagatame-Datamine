// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildFacilityParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B3E")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuildFacilityParam
  {
    [Token(Token = "0x40067C8")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40067C9")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x40067CA")]
    [FieldOffset(Offset = "0x10")]
    public string image;
    [Token(Token = "0x40067CB")]
    [FieldOffset(Offset = "0x14")]
    public int type;
    [Token(Token = "0x40067CC")]
    [FieldOffset(Offset = "0x18")]
    public int enhance;
    [Token(Token = "0x40067CD")]
    [FieldOffset(Offset = "0x1C")]
    public int increment;
    [Token(Token = "0x40067CE")]
    [FieldOffset(Offset = "0x20")]
    public long day_limit;
    [Token(Token = "0x40067CF")]
    [FieldOffset(Offset = "0x28")]
    public int rel_cnds_type;
    [Token(Token = "0x40067D0")]
    [FieldOffset(Offset = "0x2C")]
    public string rel_cnds_val1;
    [Token(Token = "0x40067D1")]
    [FieldOffset(Offset = "0x30")]
    public int rel_cnds_val2;
    [Token(Token = "0x40067D2")]
    [FieldOffset(Offset = "0x34")]
    public JSON_GuildFacilityEffectParam[] effects;

    [Token(Token = "0x6007043")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildFacilityParam()
    {
    }
  }
}
