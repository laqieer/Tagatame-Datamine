﻿// Decompiled with JetBrains decompiler
// Type: SRPG.Json_BondGroupBuffParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20019A9")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_BondGroupBuffParam
  {
    [Token(Token = "0x4005E30")]
    [FieldOffset(Offset = "0x8")]
    public string bond_group_iname;
    [Token(Token = "0x4005E31")]
    [FieldOffset(Offset = "0xC")]
    public Json_BondGroupBuffParamDetail[] buffs;

    [Token(Token = "0x600688D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_BondGroupBuffParam()
    {
    }
  }
}