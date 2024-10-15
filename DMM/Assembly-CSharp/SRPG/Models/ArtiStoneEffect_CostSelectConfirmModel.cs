// Decompiled with JetBrains decompiler
// Type: SRPG.Models.ArtiStoneEffect_CostSelectConfirmModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003306")]
  public class ArtiStoneEffect_CostSelectConfirmModel
  {
    [Token(Token = "0x400F022")]
    [FieldOffset(Offset = "0x8")]
    private ArtifactData mTargetArtifact;
    [Token(Token = "0x400F023")]
    [FieldOffset(Offset = "0xC")]
    private List<ArtifactData> mCostArtifactList;
    [Token(Token = "0x400F024")]
    [FieldOffset(Offset = "0x10")]
    private bool mIsCommonCost;
    [Token(Token = "0x400F025")]
    [FieldOffset(Offset = "0x14")]
    private ItemData mCommonCostItemData;
    [Token(Token = "0x400F026")]
    [FieldOffset(Offset = "0x18")]
    private int mCommonCostItemNum;
    [Token(Token = "0x400F027")]
    [FieldOffset(Offset = "0x1C")]
    private int mCommonCostItemNeedNum;
    [Token(Token = "0x400F028")]
    [FieldOffset(Offset = "0x20")]
    private List<ArtifactIconBlockContentNodeModel> mContentNodeModels;
    [Token(Token = "0x400F029")]
    [FieldOffset(Offset = "0x24")]
    private bool mIsOpen;

    [Token(Token = "0x17001D2C")]
    public List<ArtifactData> CostArtifactList
    {
      [Token(Token = "0x600E016"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<ArtifactData>) null;
      }
    }

    [Token(Token = "0x17001D2D")]
    public bool IsCommonCost
    {
      [Token(Token = "0x600E017"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001D2E")]
    public ItemData CommomCostItemData
    {
      [Token(Token = "0x600E018"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (ItemData) null;
      }
    }

    [Token(Token = "0x17001D2F")]
    public int CommonCostItemNum
    {
      [Token(Token = "0x600E019"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D30")]
    public List<ArtifactIconBlockContentNodeModel> ContentNodeModels
    {
      [Token(Token = "0x600E01A"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (List<ArtifactIconBlockContentNodeModel>) null;
      }
    }

    [Token(Token = "0x17001D31")]
    public bool IsOpen
    {
      [Token(Token = "0x600E01B"), Address(RVA = "0x2A5A90", Offset = "0x2A4890", VA = "0x102A5A90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E01C")]
    [Address(RVA = "0xAA2A20", Offset = "0xAA1820", VA = "0x10AA2A20")]
    public void Initialize(
      ArtifactData targetArtifact,
      List<ArtifactData> costArtifactList,
      bool isCommonCost)
    {
    }

    [Token(Token = "0x600E01D")]
    [Address(RVA = "0xAA2A80", Offset = "0xAA1880", VA = "0x10AA2A80")]
    private void SetCommonItem()
    {
    }

    [Token(Token = "0x600E01E")]
    [Address(RVA = "0xAA2BC0", Offset = "0xAA19C0", VA = "0x10AA2BC0")]
    private void SetContentNodeModelList()
    {
    }

    [Token(Token = "0x600E01F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ArtiStoneEffect_CostSelectConfirmModel()
    {
    }
  }
}
