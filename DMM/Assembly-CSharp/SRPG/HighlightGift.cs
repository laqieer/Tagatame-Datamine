// Decompiled with JetBrains decompiler
// Type: SRPG.HighlightGift
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B97")]
  public class HighlightGift
  {
    [Token(Token = "0x400693A")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400693B")]
    [FieldOffset(Offset = "0xC")]
    public string message;
    [Token(Token = "0x400693C")]
    [FieldOffset(Offset = "0x10")]
    public HighlightGiftData[] gifts;

    [Token(Token = "0x600720E")]
    [Address(RVA = "0x3757B0", Offset = "0x3745B0", VA = "0x103757B0")]
    public void Deserialize(JSON_HighlightGift json)
    {
    }

    [Token(Token = "0x600720F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public HighlightGift()
    {
    }
  }
}
