﻿// Decompiled with JetBrains decompiler
// Type: SRPG.Json_Versus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200102C")]
  [MessagePackObject(true)]
  public class Json_Versus
  {
    [Token(Token = "0x400398B")]
    [FieldOffset(Offset = "0x8")]
    public int point;
    [Token(Token = "0x400398C")]
    [FieldOffset(Offset = "0xC")]
    public Json_VersusCount[] counts;

    [Token(Token = "0x6004291")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_Versus()
    {
    }
  }
}