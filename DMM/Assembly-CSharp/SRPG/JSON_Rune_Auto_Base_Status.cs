﻿// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_Rune_Auto_Base_Status
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011C1")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_Rune_Auto_Base_Status
  {
    [Token(Token = "0x4004081")]
    [FieldOffset(Offset = "0x8")]
    public int slot;
    [Token(Token = "0x4004082")]
    [FieldOffset(Offset = "0xC")]
    public JSON_Rune_Auto_Base_Param[] param;

    [Token(Token = "0x6004B3B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_Rune_Auto_Base_Status()
    {
    }
  }
}