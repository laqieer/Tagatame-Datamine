﻿// Decompiled with JetBrains decompiler
// Type: SRPG.Json_GiftCrystal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001010")]
  [MessagePackObject(true)]
  public class Json_GiftCrystal
  {
    [Token(Token = "0x400391B")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400391C")]
    [FieldOffset(Offset = "0xC")]
    public int num;
    [Token(Token = "0x400391D")]
    [FieldOffset(Offset = "0x10")]
    public int rank;

    [Token(Token = "0x6004274")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_GiftCrystal()
    {
    }
  }
}