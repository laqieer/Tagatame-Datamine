// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CF9")]
  public class RunePrideItemData
  {
    [Token(Token = "0x4007189")]
    [FieldOffset(Offset = "0x8")]
    private RaidRewardType item_type;
    [Token(Token = "0x400718A")]
    [FieldOffset(Offset = "0xC")]
    private string item_iname;
    [Token(Token = "0x400718B")]
    [FieldOffset(Offset = "0x10")]
    private int num;
    [Token(Token = "0x400718C")]
    [FieldOffset(Offset = "0x14")]
    private List<string> sub_items;

    [Token(Token = "0x17000F8D")]
    public RaidRewardType ItemType
    {
      [Token(Token = "0x60076F3"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new RaidRewardType();
      }
    }

    [Token(Token = "0x17000F8E")]
    public string ItemIname
    {
      [Token(Token = "0x60076F4"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F8F")]
    public int Num
    {
      [Token(Token = "0x60076F5"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F90")]
    public List<string> SubItems
    {
      [Token(Token = "0x60076F6"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x60076F7")]
    [Address(RVA = "0x31AF60", Offset = "0x319D60", VA = "0x1031AF60")]
    public void Deserialize(JSON_RunePrideItemData json)
    {
    }

    [Token(Token = "0x60076F8")]
    [Address(RVA = "0x39B6E0", Offset = "0x39A4E0", VA = "0x1039B6E0")]
    public void AddNum(int _add_num)
    {
    }

    [Token(Token = "0x60076F9")]
    [Address(RVA = "0x39B6F0", Offset = "0x39A4F0", VA = "0x1039B6F0")]
    public void AddSubItems(string _iname)
    {
    }

    [Token(Token = "0x60076FA")]
    [Address(RVA = "0x39B760", Offset = "0x39A560", VA = "0x1039B760")]
    public void SetSubItems(List<string> _inames)
    {
    }

    [Token(Token = "0x60076FB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePrideItemData()
    {
    }
  }
}
