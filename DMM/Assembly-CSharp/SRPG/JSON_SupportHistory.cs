﻿// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_SupportHistory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001039")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_SupportHistory
  {
    [Token(Token = "0x40039CC")]
    [FieldOffset(Offset = "0x8")]
    public long iid;
    [Token(Token = "0x40039CD")]
    [FieldOffset(Offset = "0x10")]
    public int from;
    [Token(Token = "0x40039CE")]
    [FieldOffset(Offset = "0x14")]
    public int times;
    [Token(Token = "0x40039CF")]
    [FieldOffset(Offset = "0x18")]
    public int last;
    [Token(Token = "0x40039D0")]
    [FieldOffset(Offset = "0x1C")]
    public int gold;
    [Token(Token = "0x40039D1")]
    [FieldOffset(Offset = "0x20")]
    public int elem;

    [Token(Token = "0x60042AB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_SupportHistory()
    {
    }
  }
}