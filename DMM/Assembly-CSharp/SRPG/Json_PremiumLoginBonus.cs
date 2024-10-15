// Decompiled with JetBrains decompiler
// Type: SRPG.Json_PremiumLoginBonus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200101D")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_PremiumLoginBonus
  {
    [Token(Token = "0x4003956")]
    [FieldOffset(Offset = "0x8")]
    public string icon;
    [Token(Token = "0x4003957")]
    [FieldOffset(Offset = "0xC")]
    public Json_PremiumLoginBonusItem[] item;
    [Token(Token = "0x4003958")]
    [FieldOffset(Offset = "0x10")]
    public int coin;
    [Token(Token = "0x4003959")]
    [FieldOffset(Offset = "0x14")]
    public int gold;
    [Token(Token = "0x400395A")]
    [FieldOffset(Offset = "0x18")]
    public Json_PremiumLoginBonus premium;

    [Token(Token = "0x6004281")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_PremiumLoginBonus()
    {
    }
  }
}
