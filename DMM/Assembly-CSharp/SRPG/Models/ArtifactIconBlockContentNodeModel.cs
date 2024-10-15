// Decompiled with JetBrains decompiler
// Type: SRPG.Models.ArtifactIconBlockContentNodeModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003303")]
  public class ArtifactIconBlockContentNodeModel
  {
    [Token(Token = "0x400F012")]
    [FieldOffset(Offset = "0x8")]
    private ArtifactData mArtifactData;
    [Token(Token = "0x400F013")]
    [FieldOffset(Offset = "0xC")]
    private ItemData mItemData;
    [Token(Token = "0x400F014")]
    [FieldOffset(Offset = "0x10")]
    private ArtifactIconExModel mArtifactModel;
    [Token(Token = "0x400F015")]
    [FieldOffset(Offset = "0x14")]
    private BaseItemModel mItemModel;
    [Token(Token = "0x400F016")]
    [FieldOffset(Offset = "0x18")]
    private int mItemHaveNum;
    [Token(Token = "0x400F017")]
    [FieldOffset(Offset = "0x1C")]
    private int mItemNeedNum;
    [Token(Token = "0x400F018")]
    [FieldOffset(Offset = "0x20")]
    private int mArtifactExchanageNum;
    [Token(Token = "0x400F019")]
    [FieldOffset(Offset = "0x24")]
    private ArtifactIconBlockContentNodeModel.Type mType;

    [Token(Token = "0x17001D1D")]
    public ArtifactData ArtifactData
    {
      [Token(Token = "0x600E001"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (ArtifactData) null;
      }
    }

    [Token(Token = "0x17001D1E")]
    public ItemData ItemData
    {
      [Token(Token = "0x600E002"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (ItemData) null;
      }
    }

    [Token(Token = "0x17001D1F")]
    public ArtifactIconExModel ArtifactModel
    {
      [Token(Token = "0x600E003"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (ArtifactIconExModel) null;
      }
    }

    [Token(Token = "0x17001D20")]
    public BaseItemModel ItemModel
    {
      [Token(Token = "0x600E004"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (BaseItemModel) null;
      }
    }

    [Token(Token = "0x17001D21")]
    public int ItemHaveNum
    {
      [Token(Token = "0x600E005"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D22")]
    public int ItemNeedNum
    {
      [Token(Token = "0x600E006"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D23")]
    public int ArtifactExchanageNum
    {
      [Token(Token = "0x600E007"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D24")]
    public bool IsExchanageNum
    {
      [Token(Token = "0x600E008"), Address(RVA = "0xAA4660", Offset = "0xAA3460", VA = "0x10AA4660")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001D25")]
    public bool IsArtifact
    {
      [Token(Token = "0x600E009"), Address(RVA = "0x37ACB0", Offset = "0x379AB0", VA = "0x1037ACB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001D26")]
    public bool IsItem
    {
      [Token(Token = "0x600E00A"), Address(RVA = "0xAA4670", Offset = "0xAA3470", VA = "0x10AA4670")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E00B")]
    [Address(RVA = "0xAA4500", Offset = "0xAA3300", VA = "0x10AA4500")]
    public void Initialize(ArtifactData artifactData)
    {
    }

    [Token(Token = "0x600E00C")]
    [Address(RVA = "0xAA4640", Offset = "0xAA3440", VA = "0x10AA4640")]
    public void Initialize(ItemData itemData)
    {
    }

    [Token(Token = "0x600E00D")]
    [Address(RVA = "0xAA4460", Offset = "0xAA3260", VA = "0x10AA4460")]
    public void Initialize(ItemData itemData, int num)
    {
    }

    [Token(Token = "0x600E00E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ArtifactIconBlockContentNodeModel()
    {
    }

    [Token(Token = "0x2003304")]
    private enum Type
    {
      [Token(Token = "0x400F01B")] Artifact,
      [Token(Token = "0x400F01C")] Item,
    }
  }
}
