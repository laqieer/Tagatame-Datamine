// Decompiled with JetBrains decompiler
// Type: SRPG.NeedEquipItemList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001050")]
  public class NeedEquipItemList
  {
    [Token(Token = "0x4003A2E")]
    [FieldOffset(Offset = "0x8")]
    public Dictionary<byte, NeedEquipItemDictionary> CommonNeedNum;
    [Token(Token = "0x4003A2F")]
    [FieldOffset(Offset = "0xC")]
    public RecipeTree RecipeTree;
    [Token(Token = "0x4003A30")]
    [FieldOffset(Offset = "0x10")]
    public bool IsNotEnough;
    [Token(Token = "0x4003A31")]
    [FieldOffset(Offset = "0x14")]
    private ItemParam mLastAddParam;
    [Token(Token = "0x4003A32")]
    [FieldOffset(Offset = "0x18")]
    private int mLastAddNeedPicec;

    [Token(Token = "0x60042F6")]
    [Address(RVA = "0x11DF990", Offset = "0x11DE790", VA = "0x111DF990")]
    public NeedEquipItemList()
    {
    }

    [Token(Token = "0x60042F7")]
    [Address(RVA = "0x11DEC00", Offset = "0x11DDA00", VA = "0x111DEC00")]
    public NeedEquipItemList Clone() => (NeedEquipItemList) null;

    [Token(Token = "0x60042F8")]
    [Address(RVA = "0x11DE8A0", Offset = "0x11DD6A0", VA = "0x111DE8A0")]
    public void Add(ItemParam _param, int _need_picec, bool is_soul = false)
    {
    }

    [Token(Token = "0x60042F9")]
    [Address(RVA = "0x11DF430", Offset = "0x11DE230", VA = "0x111DF430")]
    public bool IsEnoughCommon() => new bool();

    [Token(Token = "0x60042FA")]
    [Address(RVA = "0x11DF8C0", Offset = "0x11DE6C0", VA = "0x111DF8C0")]
    public void SetRecipeTree(RecipeTree _recipe_tree, bool is_common)
    {
    }

    [Token(Token = "0x60042FB")]
    [Address(RVA = "0x11DF960", Offset = "0x11DE760", VA = "0x111DF960")]
    public void UpRecipeTree()
    {
    }

    [Token(Token = "0x60042FC")]
    [Address(RVA = "0x11DF3E0", Offset = "0x11DE1E0", VA = "0x111DF3E0")]
    public List<RecipeTree> GetCurrentRecipeTreeChildren() => (List<RecipeTree>) null;

    [Token(Token = "0x60042FD")]
    [Address(RVA = "0x11DF010", Offset = "0x11DDE10", VA = "0x111DF010")]
    public string GetCommonItemListString() => (string) null;

    [Token(Token = "0x60042FE")]
    [Address(RVA = "0x11DF790", Offset = "0x11DE590", VA = "0x111DF790")]
    public void Remove()
    {
    }

    [Token(Token = "0x60042FF")]
    [Address(RVA = "0x11DF5A0", Offset = "0x11DE3A0", VA = "0x111DF5A0")]
    public void RemoveNeedPicec()
    {
    }
  }
}
