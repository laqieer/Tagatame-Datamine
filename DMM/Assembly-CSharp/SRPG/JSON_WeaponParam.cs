﻿// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_WeaponParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EA0")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_WeaponParam
  {
    [Token(Token = "0x400802A")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400802B")]
    [FieldOffset(Offset = "0xC")]
    public int atk;
    [Token(Token = "0x400802C")]
    [FieldOffset(Offset = "0x10")]
    public int formula;

    [Token(Token = "0x6007D9D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_WeaponParam()
    {
    }
  }
}