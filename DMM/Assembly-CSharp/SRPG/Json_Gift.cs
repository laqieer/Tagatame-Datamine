// Decompiled with JetBrains decompiler
// Type: SRPG.Json_Gift
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001011")]
  [MessagePackObject(true)]
  public class Json_Gift
  {
    [Token(Token = "0x400391E")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400391F")]
    [FieldOffset(Offset = "0xC")]
    public int num;
    [Token(Token = "0x4003920")]
    [FieldOffset(Offset = "0x10")]
    public int rare;
    [Token(Token = "0x4003921")]
    [FieldOffset(Offset = "0x14")]
    public int gold;
    [Token(Token = "0x4003922")]
    [FieldOffset(Offset = "0x18")]
    public int coin;
    [Token(Token = "0x4003923")]
    [FieldOffset(Offset = "0x1C")]
    public int arenacoin;
    [Token(Token = "0x4003924")]
    [FieldOffset(Offset = "0x20")]
    public int multicoin;
    [Token(Token = "0x4003925")]
    [FieldOffset(Offset = "0x24")]
    public int kakeracoin;
    [Token(Token = "0x4003926")]
    [FieldOffset(Offset = "0x28")]
    public Json_GiftConceptCard concept_card;
    [Token(Token = "0x4003927")]
    [FieldOffset(Offset = "0x2C")]
    public Json_GiftCrystal crystal;

    [Token(Token = "0x6004275")]
    [Address(RVA = "0x11DDAC0", Offset = "0x11DC8C0", VA = "0x111DDAC0")]
    public Json_Gift()
    {
    }
  }
}
