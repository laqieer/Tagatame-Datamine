// Decompiled with JetBrains decompiler
// Type: SRPG.KeyItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A43")]
  [Serializable]
  public class KeyItem
  {
    [Token(Token = "0x40060BD")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40060BE")]
    [FieldOffset(Offset = "0xC")]
    public int num;

    [Token(Token = "0x6006BFF")]
    [Address(RVA = "0x359D20", Offset = "0x358B20", VA = "0x10359D20")]
    public bool IsHasItem() => new bool();

    [Token(Token = "0x6006C00")]
    [Address(RVA = "0x359D80", Offset = "0x358B80", VA = "0x10359D80")]
    public bool IsHas() => new bool();

    [Token(Token = "0x6006C01")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public KeyItem()
    {
    }
  }
}
