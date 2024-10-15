// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RuneDrawCostExModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003394")]
  public class RuneDrawCostExModel
  {
    [Token(Token = "0x400F426")]
    [FieldOffset(Offset = "0x8")]
    private List<RuneCost> mRuneEnhanceCostList;
    [Token(Token = "0x400F427")]
    [FieldOffset(Offset = "0xC")]
    private List<RuneCost> mRuneEvoCostList;
    [Token(Token = "0x400F428")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<string, RuneDrawCostExModel.RuneDrawCostItem> mItemList;
    [Token(Token = "0x400F429")]
    [FieldOffset(Offset = "0x14")]
    private int mUseGold;
    [Token(Token = "0x400F42A")]
    [FieldOffset(Offset = "0x18")]
    private int mUseCoin;
    [Token(Token = "0x400F42B")]
    [FieldOffset(Offset = "0x1C")]
    private bool mButtonInteractive;
    [Token(Token = "0x400F42C")]
    [FieldOffset(Offset = "0x20")]
    private int mChangeButtonIndex;

    [Token(Token = "0x17002017")]
    public Dictionary<string, RuneDrawCostExModel.RuneDrawCostItem> ItemList
    {
      [Token(Token = "0x600E5D7"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (Dictionary<string, RuneDrawCostExModel.RuneDrawCostItem>) null;
      }
    }

    [Token(Token = "0x17002018")]
    public int UseGold
    {
      [Token(Token = "0x600E5D8"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002019")]
    public int UseCoin
    {
      [Token(Token = "0x600E5D9"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700201A")]
    public bool ButtonInteractive
    {
      [Token(Token = "0x600E5DA"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700201B")]
    public int ChangeButtonIndex
    {
      [Token(Token = "0x600E5DB"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600E5DC")]
    [Address(RVA = "0xAC3140", Offset = "0xAC1F40", VA = "0x10AC3140")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600E5DD")]
    [Address(RVA = "0xAC3B40", Offset = "0xAC2940", VA = "0x10AC3B40")]
    public void SetRuneCostList(List<RuneCost> runeEnhanceCostList, List<RuneCost> runeEvoCostList)
    {
    }

    [Token(Token = "0x600E5DE")]
    [Address(RVA = "0xAC3B80", Offset = "0xAC2980", VA = "0x10AC3B80")]
    public void SetRuneEnhanceCostList(List<RuneCost> runeEnhanceCostList, bool isRemeasurement = true)
    {
    }

    [Token(Token = "0x600E5DF")]
    [Address(RVA = "0xAC3810", Offset = "0xAC2610", VA = "0x10AC3810")]
    public void SetEvoRuneCostList(List<RuneCost> runeEvoCostList, bool isRemeasurement = true)
    {
    }

    [Token(Token = "0x600E5E0")]
    [Address(RVA = "0xAC32A0", Offset = "0xAC20A0", VA = "0x10AC32A0")]
    private void RuneCostClear()
    {
    }

    [Token(Token = "0x600E5E1")]
    [Address(RVA = "0xAC31A0", Offset = "0xAC1FA0", VA = "0x10AC31A0")]
    private void RuneCostAdd(RuneCost cost)
    {
    }

    [Token(Token = "0x600E5E2")]
    [Address(RVA = "0xAC3350", Offset = "0xAC2150", VA = "0x10AC3350")]
    public void RuneCostRemeasurement()
    {
    }

    [Token(Token = "0x600E5E3")]
    [Address(RVA = "0xAC3840", Offset = "0xAC2640", VA = "0x10AC3840")]
    public void SetRuneCostItemHaveAndIconPath()
    {
    }

    [Token(Token = "0x600E5E4")]
    [Address(RVA = "0xAC35E0", Offset = "0xAC23E0", VA = "0x10AC35E0")]
    public void SetButtonInteractive()
    {
    }

    [Token(Token = "0x600E5E5")]
    [Address(RVA = "0x2A68E0", Offset = "0x2A56E0", VA = "0x102A68E0")]
    public void SetChangeButtonIndex(int changeButtonIndex)
    {
    }

    [Token(Token = "0x600E5E6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneDrawCostExModel()
    {
    }

    [Token(Token = "0x2003395")]
    public class RuneDrawCostItem
    {
      [Token(Token = "0x400F42D")]
      [FieldOffset(Offset = "0x8")]
      public string path;
      [Token(Token = "0x400F42E")]
      [FieldOffset(Offset = "0xC")]
      public int value;
      [Token(Token = "0x400F42F")]
      [FieldOffset(Offset = "0x10")]
      public int have;

      [Token(Token = "0x600E5E7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RuneDrawCostItem()
      {
      }
    }
  }
}
