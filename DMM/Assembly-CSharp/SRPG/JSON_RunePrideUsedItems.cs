﻿// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RunePrideUsedItems
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011C6")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RunePrideUsedItems
  {
    [Token(Token = "0x40040A1")]
    [FieldOffset(Offset = "0x8")]
    public int gold;
    [Token(Token = "0x40040A2")]
    [FieldOffset(Offset = "0xC")]
    public int coin;
    [Token(Token = "0x40040A3")]
    [FieldOffset(Offset = "0x10")]
    public JSON_RunePrideUsedItemData[] items;

    [Token(Token = "0x6004B3F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RunePrideUsedItems()
    {
    }
  }
}