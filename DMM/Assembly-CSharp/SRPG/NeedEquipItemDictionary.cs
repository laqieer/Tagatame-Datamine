// Decompiled with JetBrains decompiler
// Type: SRPG.NeedEquipItemDictionary
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200104C")]
  public class NeedEquipItemDictionary
  {
    [Token(Token = "0x4003A24")]
    [FieldOffset(Offset = "0x8")]
    public List<NeedEquipItem> list;
    [Token(Token = "0x4003A25")]
    [FieldOffset(Offset = "0xC")]
    private int need_picec;
    [Token(Token = "0x4003A26")]
    [FieldOffset(Offset = "0x10")]
    private ItemData data;
    [Token(Token = "0x4003A27")]
    [FieldOffset(Offset = "0x14")]
    public ItemParam CommonItemParam;

    [Token(Token = "0x1700062A")]
    public int CommonEquipItemNum
    {
      [Token(Token = "0x60042E1"), Address(RVA = "0x11DE840", Offset = "0x11DD640", VA = "0x111DE840")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700062B")]
    public bool IsEnough
    {
      [Token(Token = "0x60042E2"), Address(RVA = "0x11DE870", Offset = "0x11DD670", VA = "0x111DE870")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700062C")]
    public int NeedPicec
    {
      [Token(Token = "0x60042E3"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60042E4")]
    [Address(RVA = "0x11DE750", Offset = "0x11DD550", VA = "0x111DE750")]
    public NeedEquipItemDictionary(ItemParam item_param, bool is_soul = false)
    {
    }

    [Token(Token = "0x60042E5")]
    [Address(RVA = "0x11DE4B0", Offset = "0x11DD2B0", VA = "0x111DE4B0")]
    public NeedEquipItemDictionary Clone() => (NeedEquipItemDictionary) null;

    [Token(Token = "0x60042E6")]
    [Address(RVA = "0x11DE340", Offset = "0x11DD140", VA = "0x111DE340")]
    public void Add(ItemParam _param, int _need_picec)
    {
    }

    [Token(Token = "0x60042E7")]
    [Address(RVA = "0x11DE580", Offset = "0x11DD380", VA = "0x111DE580")]
    public void Remove(ItemParam _param)
    {
    }

    [Token(Token = "0x60042E8")]
    [Address(RVA = "0x11DE610", Offset = "0x11DD410", VA = "0x111DE610")]
    public void Remove(ItemParam _param, int _need_picec)
    {
    }
  }
}
