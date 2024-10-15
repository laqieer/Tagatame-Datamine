// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ReplaceSprite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200266F")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_ReplaceSprite
  {
    [Token(Token = "0x400B39F")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400B3A0")]
    [FieldOffset(Offset = "0xC")]
    public JSON_ReplacePeriod[] periods;

    [Token(Token = "0x600AB9A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ReplaceSprite()
    {
    }
  }
}
