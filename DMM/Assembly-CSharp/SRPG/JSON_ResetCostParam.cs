﻿// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ResetCostParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CAD")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_ResetCostParam
  {
    [Token(Token = "0x400709A")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400709B")]
    [FieldOffset(Offset = "0xC")]
    public JSON_ResetCostInfoParam[] cost;

    [Token(Token = "0x6007619")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ResetCostParam()
    {
    }
  }
}