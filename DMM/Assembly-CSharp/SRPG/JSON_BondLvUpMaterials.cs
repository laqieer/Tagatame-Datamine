﻿// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_BondLvUpMaterials
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002096")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_BondLvUpMaterials
  {
    [Token(Token = "0x4008C80")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4008C81")]
    [FieldOffset(Offset = "0xC")]
    public JSON_BondUsePiece[] mats;

    [Token(Token = "0x60087A4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_BondLvUpMaterials()
    {
    }
  }
}