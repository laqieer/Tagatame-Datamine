// Decompiled with JetBrains decompiler
// Type: SRPG.Models.ConceptCardIconExModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003314")]
  public class ConceptCardIconExModel
  {
    [Token(Token = "0x400F0CC")]
    private const string ItenIconSmallPath = "ItemIcon/small";
    [Token(Token = "0x400F0CD")]
    private const int Empty = -1;
    [Token(Token = "0x400F0CE")]
    [FieldOffset(Offset = "0x8")]
    private ConceptCardData mData;
    [Token(Token = "0x400F0CF")]
    [FieldOffset(Offset = "0xC")]
    private ConceptCardParam mParam;
    [Token(Token = "0x400F0D0")]
    [FieldOffset(Offset = "0x10")]
    private bool mIsIncludeOverWrite;
    [Token(Token = "0x400F0D1")]
    [FieldOffset(Offset = "0x14")]
    private string mIconPath;
    [Token(Token = "0x400F0D2")]
    [FieldOffset(Offset = "0x18")]
    private string mName;
    [Token(Token = "0x400F0D3")]
    [FieldOffset(Offset = "0x1C")]
    private string mLevel;
    [Token(Token = "0x400F0D4")]
    [FieldOffset(Offset = "0x20")]
    private string mLevelCap;
    [Token(Token = "0x400F0D5")]
    [FieldOffset(Offset = "0x24")]
    private Sprite mRarityFrame;
    [Token(Token = "0x400F0D6")]
    [FieldOffset(Offset = "0x28")]
    private int mTrust;
    [Token(Token = "0x400F0D7")]
    [FieldOffset(Offset = "0x2C")]
    private bool mIsTrust;
    [Token(Token = "0x400F0D8")]
    [FieldOffset(Offset = "0x30")]
    private Sprite mOwnerIcon;
    [Token(Token = "0x400F0D9")]
    [FieldOffset(Offset = "0x34")]
    private int mEquipTypeImageIndex;
    [Token(Token = "0x400F0DA")]
    [FieldOffset(Offset = "0x38")]
    private string mCardNum;
    [Token(Token = "0x400F0DB")]
    [FieldOffset(Offset = "0x3C")]
    private int mAwakeImageIndex;
    [Token(Token = "0x400F0DC")]
    [FieldOffset(Offset = "0x40")]
    private Dictionary<ConceptCardIconExModel.VisibleKey, bool> mVisibleInternalDic;
    [Token(Token = "0x400F0DD")]
    [FieldOffset(Offset = "0x44")]
    private Dictionary<ConceptCardIconExModel.VisibleKey, bool> mVisibleExternalDic;

    [Token(Token = "0x600E0CA")]
    [Address(RVA = "0xAAC2D0", Offset = "0xAAB0D0", VA = "0x10AAC2D0")]
    public bool Visible(ConceptCardIconExModel.VisibleKey key) => new bool();

    [Token(Token = "0x17001D90")]
    public ConceptCardData Data
    {
      [Token(Token = "0x600E0CB"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (ConceptCardData) null;
      }
    }

    [Token(Token = "0x17001D91")]
    public ConceptCardParam Param
    {
      [Token(Token = "0x600E0CC"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (ConceptCardParam) null;
      }
    }

    [Token(Token = "0x17001D92")]
    public string Name
    {
      [Token(Token = "0x600E0CD"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D93")]
    public string IconImage
    {
      [Token(Token = "0x600E0CE"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D94")]
    public string Level
    {
      [Token(Token = "0x600E0CF"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D95")]
    public string LevelCap
    {
      [Token(Token = "0x600E0D0"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D96")]
    public Sprite RarityFrame
    {
      [Token(Token = "0x600E0D1"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x17001D97")]
    public int Trust
    {
      [Token(Token = "0x600E0D2"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D98")]
    public string TrustEmpty
    {
      [Token(Token = "0x600E0D3"), Address(RVA = "0xAAC420", Offset = "0xAAB220", VA = "0x10AAC420")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D99")]
    public bool IsTrust
    {
      [Token(Token = "0x600E0D4"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001D9A")]
    public Sprite OwnerIcon
    {
      [Token(Token = "0x600E0D5"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x17001D9B")]
    public int EquipTypeImageIndex
    {
      [Token(Token = "0x600E0D6"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D9C")]
    public string CardNum
    {
      [Token(Token = "0x600E0D7"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E0D8")]
    [Address(RVA = "0xAAC360", Offset = "0xAAB160", VA = "0x10AAC360")]
    public ConceptCardIconExModel()
    {
    }

    [Token(Token = "0x600E0D9")]
    [Address(RVA = "0xAAAFC0", Offset = "0xAA9DC0", VA = "0x10AAAFC0")]
    public void Initialize(ConceptCardData data, bool isIncludeOverWrite = false)
    {
    }

    [Token(Token = "0x600E0DA")]
    [Address(RVA = "0xAAAF60", Offset = "0xAA9D60", VA = "0x10AAAF60")]
    public void Initialize(ConceptCardParam param)
    {
    }

    [Token(Token = "0x600E0DB")]
    [Address(RVA = "0xAAC280", Offset = "0xAAB080", VA = "0x10AAC280")]
    private void Setup(ConceptCardParam param)
    {
    }

    [Token(Token = "0x600E0DC")]
    [Address(RVA = "0xAAB4B0", Offset = "0xAAA2B0", VA = "0x10AAB4B0")]
    private void SetInitParam()
    {
    }

    [Token(Token = "0x600E0DD")]
    [Address(RVA = "0xAAB800", Offset = "0xAAA600", VA = "0x10AAB800")]
    private void SetParam()
    {
    }

    [Token(Token = "0x600E0DE")]
    [Address(RVA = "0xAAB420", Offset = "0xAAA220", VA = "0x10AAB420")]
    private void SetIconImage()
    {
    }

    [Token(Token = "0x600E0DF")]
    [Address(RVA = "0xAAB650", Offset = "0xAAA450", VA = "0x10AAB650")]
    private void SetName()
    {
    }

    [Token(Token = "0x600E0E0")]
    [Address(RVA = "0xAAB580", Offset = "0xAAA380", VA = "0x10AAB580")]
    private void SetLevelGroup()
    {
    }

    [Token(Token = "0x600E0E1")]
    [Address(RVA = "0xAABEE0", Offset = "0xAAACE0", VA = "0x10AABEE0")]
    private void SetRarity()
    {
    }

    [Token(Token = "0x600E0E2")]
    [Address(RVA = "0xAAC170", Offset = "0xAAAF70", VA = "0x10AAC170")]
    private void SetTrust()
    {
    }

    [Token(Token = "0x600E0E3")]
    [Address(RVA = "0xAAC1C0", Offset = "0xAAAFC0", VA = "0x10AAC1C0")]
    public void SetTrust(int trust)
    {
    }

    [Token(Token = "0x600E0E4")]
    [Address(RVA = "0xAAB6C0", Offset = "0xAAA4C0", VA = "0x10AAB6C0")]
    public void SetNonTrust()
    {
    }

    [Token(Token = "0x600E0E5")]
    [Address(RVA = "0xAAB3F0", Offset = "0xAAA1F0", VA = "0x10AAB3F0")]
    public void SetFavorite()
    {
    }

    [Token(Token = "0x600E0E6")]
    [Address(RVA = "0xAAB700", Offset = "0xAAA500", VA = "0x10AAB700")]
    private void SetOwnerIcon()
    {
    }

    [Token(Token = "0x600E0E7")]
    [Address(RVA = "0xAAC000", Offset = "0xAAAE00", VA = "0x10AAC000")]
    public void SetSameCardIcon()
    {
    }

    [Token(Token = "0x600E0E8")]
    [Address(RVA = "0xAAB180", Offset = "0xAA9F80", VA = "0x10AAB180")]
    private void SetEquipTypeImage()
    {
    }

    [Token(Token = "0x600E0E9")]
    [Address(RVA = "0xAAB320", Offset = "0xAAA120", VA = "0x10AAB320")]
    public void SetExistImage()
    {
    }

    [Token(Token = "0x600E0EA")]
    [Address(RVA = "0xAAB130", Offset = "0xAA9F30", VA = "0x10AAB130")]
    public void SetCardNum(int num)
    {
    }

    [Token(Token = "0x600E0EB")]
    [Address(RVA = "0xAAB6E0", Offset = "0xAAA4E0", VA = "0x10AAB6E0")]
    public void SetNotSellFlag(bool flag)
    {
    }

    [Token(Token = "0x600E0EC")]
    [Address(RVA = "0xAABFE0", Offset = "0xAAADE0", VA = "0x10AABFE0")]
    public void SetRecommendFlag(bool flag)
    {
    }

    [Token(Token = "0x600E0ED")]
    [Address(RVA = "0xAAB160", Offset = "0xAA9F60", VA = "0x10AAB160")]
    public void SetDisableObjectFlag(bool flag)
    {
    }

    [Token(Token = "0x600E0EE")]
    [Address(RVA = "0xAAC0F0", Offset = "0xAAAEF0", VA = "0x10AAC0F0")]
    public void SetSelectObjectFlag(bool flag)
    {
    }

    [Token(Token = "0x600E0EF")]
    [Address(RVA = "0xAAB080", Offset = "0xAA9E80", VA = "0x10AAB080")]
    public void SetAwakeSprite()
    {
    }

    [Token(Token = "0x600E0F0")]
    [Address(RVA = "0xAAACA0", Offset = "0xAA9AA0", VA = "0x10AAACA0")]
    public UnitData GetOwner(bool is_include_over_write) => (UnitData) null;

    [Token(Token = "0x600E0F1")]
    [Address(RVA = "0xAAACD0", Offset = "0xAA9AD0", VA = "0x10AAACD0")]
    public int GetRarity() => new int();

    [Token(Token = "0x600E0F2")]
    [Address(RVA = "0xAAAC20", Offset = "0xAA9A20", VA = "0x10AAAC20")]
    public int GetAwakeImageIndex(ImageArray imageArray) => new int();

    [Token(Token = "0x600E0F3")]
    [Address(RVA = "0xAAACF0", Offset = "0xAA9AF0", VA = "0x10AAACF0")]
    public void InitVisible(
      Dictionary<ConceptCardIconExModel.VisibleKey, bool> visibleDic,
      bool isDefault = false)
    {
    }

    [Token(Token = "0x600E0F4")]
    [Address(RVA = "0xAAC1F0", Offset = "0xAAAFF0", VA = "0x10AAC1F0")]
    public void SetVisible(
      Dictionary<ConceptCardIconExModel.VisibleKey, bool> visibleDic,
      ConceptCardIconExModel.VisibleKey key,
      bool isFlag)
    {
    }

    [Token(Token = "0x600E0F5")]
    [Address(RVA = "0xAAB4F0", Offset = "0xAAA2F0", VA = "0x10AAB4F0")]
    private void SetInternalVisible(ConceptCardIconExModel.VisibleKey key, bool isFlag)
    {
    }

    [Token(Token = "0x600E0F6")]
    [Address(RVA = "0xAAB360", Offset = "0xAAA160", VA = "0x10AAB360")]
    public void SetExternalVisible(ConceptCardIconExModel.VisibleKey key, bool isFlag)
    {
    }

    [Token(Token = "0x2003315")]
    public enum VisibleKey
    {
      [Token(Token = "0x400F0DF")] Icon,
      [Token(Token = "0x400F0E0")] Name,
      [Token(Token = "0x400F0E1")] LevelTitle,
      [Token(Token = "0x400F0E2")] Level,
      [Token(Token = "0x400F0E3")] LevelCap,
      [Token(Token = "0x400F0E4")] Rarity,
      [Token(Token = "0x400F0E5")] RarityFrame,
      [Token(Token = "0x400F0E6")] Trust,
      [Token(Token = "0x400F0E7")] Favorite,
      [Token(Token = "0x400F0E8")] Owner,
      [Token(Token = "0x400F0E9")] OwnerIcon,
      [Token(Token = "0x400F0EA")] SameCardIcon,
      [Token(Token = "0x400F0EB")] EquipTypeImage,
      [Token(Token = "0x400F0EC")] ExistSwitchOn,
      [Token(Token = "0x400F0ED")] ExistSwitchOff,
      [Token(Token = "0x400F0EE")] CardNum,
      [Token(Token = "0x400F0EF")] NotSale,
      [Token(Token = "0x400F0F0")] Recommend,
      [Token(Token = "0x400F0F1")] DisableObject,
      [Token(Token = "0x400F0F2")] SelectObject,
      [Token(Token = "0x400F0F3")] AwakeIcon,
    }
  }
}
