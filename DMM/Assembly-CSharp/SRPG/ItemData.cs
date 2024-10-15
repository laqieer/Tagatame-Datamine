// Decompiled with JetBrains decompiler
// Type: SRPG.ItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FD3")]
  [MessagePackObject(true)]
  public class ItemData
  {
    [Token(Token = "0x40037E4")]
    [FieldOffset(Offset = "0x8")]
    private long mUniqueID;
    [Token(Token = "0x40037E5")]
    [FieldOffset(Offset = "0x10")]
    private ItemParam mItemParam;
    [Token(Token = "0x40037E6")]
    [FieldOffset(Offset = "0x14")]
    private RarityParam mRarityParam;
    [Token(Token = "0x40037E7")]
    [FieldOffset(Offset = "0x18")]
    private SkillData mSkill;
    [Token(Token = "0x40037E8")]
    [FieldOffset(Offset = "0x1C")]
    private ItemData.ItemFlags mFlags;
    [Token(Token = "0x40037E9")]
    [FieldOffset(Offset = "0x20")]
    protected int mNum;
    [Token(Token = "0x40037EA")]
    [FieldOffset(Offset = "0x24")]
    private bool mIsNew;

    [Token(Token = "0x170005E3")]
    public int No
    {
      [Token(Token = "0x60041C3"), Address(RVA = "0x3DA4E0", Offset = "0x3D92E0", VA = "0x103DA4E0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170005E4")]
    public long UniqueID
    {
      [Token(Token = "0x60041C4"), Address(RVA = "0x305C20", Offset = "0x304A20", VA = "0x10305C20")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x170005E5")]
    public ItemParam Param
    {
      [Token(Token = "0x60041C5"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (ItemParam) null;
      }
    }

    [Token(Token = "0x170005E6")]
    public string ItemID
    {
      [Token(Token = "0x60041C6"), Address(RVA = "0x2B0C50", Offset = "0x2AFA50", VA = "0x102B0C50")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170005E7")]
    public int Num
    {
      [Token(Token = "0x60041C7"), Address(RVA = "0x1198480", Offset = "0x1197280", VA = "0x11198480")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170005E8")]
    public int NumNonCap
    {
      [Token(Token = "0x60041C8"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170005E9")]
    public SkillData Skill
    {
      [Token(Token = "0x60041C9"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (SkillData) null;
      }
    }

    [Token(Token = "0x170005EA")]
    public bool IsUsed
    {
      [Token(Token = "0x60041CA"), Address(RVA = "0xAA4660", Offset = "0xAA3460", VA = "0x10AA4660")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170005EB")]
    public EItemType ItemType
    {
      [Token(Token = "0x60041CB"), Address(RVA = "0x919970", Offset = "0x918770", VA = "0x10919970")] get
      {
        return new EItemType();
      }
    }

    [Token(Token = "0x170005EC")]
    public int Rarity
    {
      [Token(Token = "0x60041CC"), Address(RVA = "0x919950", Offset = "0x918750", VA = "0x10919950")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170005ED")]
    public RarityParam RarityParam
    {
      [Token(Token = "0x60041CD"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (RarityParam) null;
      }
    }

    [Token(Token = "0x170005EE")]
    public int HaveCap
    {
      [Token(Token = "0x60041CE"), Address(RVA = "0x1198420", Offset = "0x1197220", VA = "0x11198420")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170005EF")]
    public int InventoryCap
    {
      [Token(Token = "0x60041CF"), Address(RVA = "0x1198440", Offset = "0x1197240", VA = "0x11198440")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170005F0")]
    public int Buy
    {
      [Token(Token = "0x60041D0"), Address(RVA = "0x1198400", Offset = "0x1197200", VA = "0x11198400")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170005F1")]
    public int Sell
    {
      [Token(Token = "0x60041D1"), Address(RVA = "0x1198510", Offset = "0x1197310", VA = "0x11198510")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170005F2")]
    public RecipeParam Recipe
    {
      [Token(Token = "0x60041D2"), Address(RVA = "0x11984E0", Offset = "0x11972E0", VA = "0x111984E0")] get
      {
        return (RecipeParam) null;
      }
    }

    [Token(Token = "0x60041D3")]
    [Address(RVA = "0x1198010", Offset = "0x1196E10", VA = "0x11198010")]
    public void SetFlag(ItemData.ItemFlags flag)
    {
    }

    [Token(Token = "0x60041D4")]
    [Address(RVA = "0x1198000", Offset = "0x1196E00", VA = "0x11198000")]
    public void ResetFlag(ItemData.ItemFlags flag)
    {
    }

    [Token(Token = "0x60041D5")]
    [Address(RVA = "0x1197FF0", Offset = "0x1196DF0", VA = "0x11197FF0")]
    public void ResetAllFlag(ItemData.ItemFlags flag)
    {
    }

    [Token(Token = "0x60041D6")]
    [Address(RVA = "0x1197FD0", Offset = "0x1196DD0", VA = "0x11197FD0")]
    public bool GetFlag(ItemData.ItemFlags flag) => new bool();

    [Token(Token = "0x170005F3")]
    public bool IsNew
    {
      [Token(Token = "0x60041D7"), Address(RVA = "0x1198470", Offset = "0x1197270", VA = "0x11198470")] get
      {
        return new bool();
      }
      [Token(Token = "0x60041D8"), Address(RVA = "0x1198550", Offset = "0x1197350", VA = "0x11198550")] set
      {
      }
    }

    [Token(Token = "0x170005F4")]
    public bool IsNewSkin
    {
      [Token(Token = "0x60041D9"), Address(RVA = "0x1198460", Offset = "0x1197260", VA = "0x11198460")] get
      {
        return new bool();
      }
      [Token(Token = "0x60041DA"), Address(RVA = "0x1198530", Offset = "0x1197330", VA = "0x11198530")] set
      {
      }
    }

    [Token(Token = "0x60041DB")]
    [Address(RVA = "0x1197F40", Offset = "0x1196D40", VA = "0x11197F40")]
    public bool Deserialize(Json_Item json) => new bool();

    [Token(Token = "0x60041DC")]
    [Address(RVA = "0x1198070", Offset = "0x1196E70", VA = "0x11198070")]
    public bool Setup(long iid, string iname, int num) => new bool();

    [Token(Token = "0x60041DD")]
    [Address(RVA = "0x1198230", Offset = "0x1197030", VA = "0x11198230")]
    public bool Setup(long iid, ItemParam itemParam, int num) => new bool();

    [Token(Token = "0x60041DE")]
    [Address(RVA = "0x1197F70", Offset = "0x1196D70", VA = "0x11197F70")]
    public void Gain(int num)
    {
    }

    [Token(Token = "0x60041DF")]
    [Address(RVA = "0x11983A0", Offset = "0x11971A0", VA = "0x111983A0")]
    public void Used(int num)
    {
    }

    [Token(Token = "0x60041E0")]
    [Address(RVA = "0x1198020", Offset = "0x1196E20", VA = "0x11198020")]
    public void SetNum(int num)
    {
    }

    [Token(Token = "0x60041E1")]
    [Address(RVA = "0x1198330", Offset = "0x1197130", VA = "0x11198330", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x60041E2")]
    [Address(RVA = "0x1197EB0", Offset = "0x1196CB0", VA = "0x11197EB0")]
    public bool CheckEquipEnhanceMaterial() => new bool();

    [Token(Token = "0x60041E3")]
    [Address(RVA = "0x9DE5F0", Offset = "0x9DD3F0", VA = "0x109DE5F0")]
    public int GetRankCap() => new int();

    [Token(Token = "0x60041E4")]
    [Address(RVA = "0x1197EE0", Offset = "0x1196CE0", VA = "0x11197EE0")]
    public static ItemData CreateItemDataForDisplay(string iname, int num = 0) => (ItemData) null;

    [Token(Token = "0x60041E5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ItemData()
    {
    }

    [Token(Token = "0x2000FD4")]
    [Flags]
    public enum ItemFlags
    {
      [Token(Token = "0x40037EC")] NewItem = 1,
      [Token(Token = "0x40037ED")] NewSkin = 2,
    }
  }
}
