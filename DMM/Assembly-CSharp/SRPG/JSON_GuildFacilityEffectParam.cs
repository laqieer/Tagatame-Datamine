// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildFacilityEffectParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B3F")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuildFacilityEffectParam
  {
    [Token(Token = "0x40067D3")]
    [FieldOffset(Offset = "0x8")]
    public int lv;
    [Token(Token = "0x40067D4")]
    [FieldOffset(Offset = "0xC")]
    public int training_limit;
    [Token(Token = "0x40067D5")]
    [FieldOffset(Offset = "0x10")]
    public string[] buff;
    [Token(Token = "0x40067D6")]
    [FieldOffset(Offset = "0x14")]
    public int mem_cnt;
    [Token(Token = "0x40067D7")]
    [FieldOffset(Offset = "0x18")]
    public int sub_mas;
    [Token(Token = "0x40067D8")]
    [FieldOffset(Offset = "0x1C")]
    public int shop_cnt;

    [Token(Token = "0x6007044")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildFacilityEffectParam()
    {
    }
  }
}
