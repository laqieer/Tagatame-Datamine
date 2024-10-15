// Decompiled with JetBrains decompiler
// Type: SRPG.GvGUsedUnitData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025C4")]
  public class GvGUsedUnitData
  {
    [Token(Token = "0x400AF40")]
    [FieldOffset(Offset = "0x8")]
    public long uiid;
    [Token(Token = "0x400AF41")]
    [FieldOffset(Offset = "0x10")]
    public int remainDay;
    [Token(Token = "0x400AF42")]
    [FieldOffset(Offset = "0x18")]
    public DateTime usedDay;

    [Token(Token = "0x600A7C9")]
    [Address(RVA = "0x6C3BF0", Offset = "0x6C29F0", VA = "0x106C3BF0")]
    public void Deserialize(JSON_GvGUsedUnitData json)
    {
    }

    [Token(Token = "0x600A7CA")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GvGUsedUnitData()
    {
    }
  }
}
