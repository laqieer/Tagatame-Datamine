﻿// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ResonanceRecipeParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CC0")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_ResonanceRecipeParam
  {
    [Token(Token = "0x40070CB")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40070CC")]
    [FieldOffset(Offset = "0xC")]
    public JSON_ResonanceUseItemParam[] items;

    [Token(Token = "0x600764E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ResonanceRecipeParam()
    {
    }
  }
}