// Decompiled with JetBrains decompiler
// Type: SRPG.BookmarkDropResultContentParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20020D8")]
  public class BookmarkDropResultContentParam : ContentSource.Param
  {
    [Token(Token = "0x4008DCC")]
    [FieldOffset(Offset = "0x10")]
    public string ItemIname;
    [Token(Token = "0x4008DCD")]
    [FieldOffset(Offset = "0x14")]
    public int ItemNum;
    [Token(Token = "0x4008DCE")]
    [FieldOffset(Offset = "0x18")]
    private BookmarkDropResultContentNode mNode;

    [Token(Token = "0x60088F9")]
    [Address(RVA = "0x4A3930", Offset = "0x4A2730", VA = "0x104A3930", Slot = "12")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x60088FA")]
    [Address(RVA = "0x492EB0", Offset = "0x491CB0", VA = "0x10492EB0", Slot = "13")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x60088FB")]
    [Address(RVA = "0x4A3B00", Offset = "0x4A2900", VA = "0x104A3B00")]
    public void Refresh()
    {
    }

    [Token(Token = "0x60088FC")]
    [Address(RVA = "0x418450", Offset = "0x417250", VA = "0x10418450")]
    public BookmarkDropResultContentParam()
    {
    }
  }
}
