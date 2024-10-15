// Decompiled with JetBrains decompiler
// Type: SRPG.RecipeTree
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200104F")]
  public class RecipeTree
  {
    [Token(Token = "0x4003A2A")]
    [FieldOffset(Offset = "0x8")]
    private List<RecipeTree> children;
    [Token(Token = "0x4003A2B")]
    [FieldOffset(Offset = "0xC")]
    private RecipeTree parent;
    [Token(Token = "0x4003A2C")]
    [FieldOffset(Offset = "0x10")]
    private bool is_common;
    [Token(Token = "0x4003A2D")]
    [FieldOffset(Offset = "0x14")]
    private ItemParam param;

    [Token(Token = "0x1700062D")]
    public List<RecipeTree> Children
    {
      [Token(Token = "0x60042ED"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (List<RecipeTree>) null;
      }
    }

    [Token(Token = "0x1700062E")]
    public RecipeTree Parent
    {
      [Token(Token = "0x60042EE"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (RecipeTree) null;
      }
    }

    [Token(Token = "0x1700062F")]
    public bool IsCommon
    {
      [Token(Token = "0x60042EF"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000630")]
    public string iname
    {
      [Token(Token = "0x60042F0"), Address(RVA = "0x7A6290", Offset = "0x7A5090", VA = "0x107A6290")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60042F1")]
    [Address(RVA = "0x11E94B0", Offset = "0x11E82B0", VA = "0x111E94B0")]
    public RecipeTree(ItemParam param)
    {
    }

    [Token(Token = "0x60042F2")]
    [Address(RVA = "0x11E9300", Offset = "0x11E8100", VA = "0x111E9300")]
    public RecipeTree Clone() => (RecipeTree) null;

    [Token(Token = "0x60042F3")]
    [Address(RVA = "0x11E9420", Offset = "0x11E8220", VA = "0x111E9420")]
    public void SetChild(RecipeTree child)
    {
    }

    [Token(Token = "0x60042F4")]
    [Address(RVA = "0x11E9480", Offset = "0x11E8280", VA = "0x111E9480")]
    public void SetIsCommon()
    {
    }

    [Token(Token = "0x60042F5")]
    [Address(RVA = "0x11E93D0", Offset = "0x11E81D0", VA = "0x111E93D0")]
    public void RemoveLastAt()
    {
    }
  }
}
