// Decompiled with JetBrains decompiler
// Type: SRPG.HighlightGiftData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B98")]
  public class HighlightGiftData
  {
    [Token(Token = "0x400693D")]
    [FieldOffset(Offset = "0x8")]
    public HighlightGiftType type;
    [Token(Token = "0x400693E")]
    [FieldOffset(Offset = "0xC")]
    public string item;
    [Token(Token = "0x400693F")]
    [FieldOffset(Offset = "0x10")]
    public int num;

    [Token(Token = "0x6007210")]
    [Address(RVA = "0x31AF60", Offset = "0x319D60", VA = "0x1031AF60")]
    public void Deserialize(JSON_HighlightGiftData json)
    {
    }

    [Token(Token = "0x6007211")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public HighlightGiftData()
    {
    }
  }
}
