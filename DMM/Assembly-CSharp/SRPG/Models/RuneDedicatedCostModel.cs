// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RuneDedicatedCostModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200338A")]
  public class RuneDedicatedCostModel
  {
    [Token(Token = "0x400F3D9")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Color32 EnoughColor;
    [Token(Token = "0x400F3DA")]
    [FieldOffset(Offset = "0x4")]
    private static readonly Color32 NotEnoughColor;
    [Token(Token = "0x400F3DB")]
    [FieldOffset(Offset = "0x8")]
    private ItemData costItemData;
    [Token(Token = "0x400F3DC")]
    [FieldOffset(Offset = "0xC")]
    private int costNeedNum;
    [Token(Token = "0x400F3DD")]
    [FieldOffset(Offset = "0x10")]
    private int costAmountNum;
    [Token(Token = "0x400F3DE")]
    [FieldOffset(Offset = "0x14")]
    private Color costNeedTextColor;

    [Token(Token = "0x17001FD3")]
    public ItemData CostItemData
    {
      [Token(Token = "0x600E564"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (ItemData) null;
      }
    }

    [Token(Token = "0x17001FD4")]
    public int Need
    {
      [Token(Token = "0x600E565"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001FD5")]
    public int Amount
    {
      [Token(Token = "0x600E566"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001FD6")]
    public Color NeedTextColor
    {
      [Token(Token = "0x600E567"), Address(RVA = "0xAB0F90", Offset = "0xAAFD90", VA = "0x10AB0F90")] get
      {
        return new Color();
      }
    }

    [Token(Token = "0x600E568")]
    [Address(RVA = "0xAC12B0", Offset = "0xAC00B0", VA = "0x10AC12B0")]
    public void Initialize(ItemParam itemParam, int needNum)
    {
    }

    [Token(Token = "0x600E569")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneDedicatedCostModel()
    {
    }

    [Token(Token = "0x600E56A")]
    [Address(RVA = "0xAC1420", Offset = "0xAC0220", VA = "0x10AC1420")]
    static RuneDedicatedCostModel()
    {
    }
  }
}
