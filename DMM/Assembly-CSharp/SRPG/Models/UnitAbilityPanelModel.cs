// Decompiled with JetBrains decompiler
// Type: SRPG.Models.UnitAbilityPanelModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033C8")]
  public class UnitAbilityPanelModel
  {
    [Token(Token = "0x400F52A")]
    [FieldOffset(Offset = "0x8")]
    private readonly string HIDE_ABILITYNAME_NAME;
    [Token(Token = "0x400F52B")]
    private const int OUT_RENGE_SLOT = -1;
    [Token(Token = "0x400F52C")]
    [FieldOffset(Offset = "0xC")]
    private bool mIsHideMode;
    [Token(Token = "0x400F52D")]
    [FieldOffset(Offset = "0x10")]
    private UnitAbilityPanelModel.Mode mPanelMode;
    [Token(Token = "0x400F52E")]
    [FieldOffset(Offset = "0x14")]
    private UnitData mUnitData;
    [Token(Token = "0x400F52F")]
    [FieldOffset(Offset = "0x18")]
    private AbilityData mAbilityData;
    [Token(Token = "0x400F530")]
    [FieldOffset(Offset = "0x1C")]
    private AbilityParam mAbilityParam;
    [Token(Token = "0x400F531")]
    [FieldOffset(Offset = "0x20")]
    private int mSlotIndex;
    [Token(Token = "0x400F532")]
    [FieldOffset(Offset = "0x24")]
    private Color mBgImageColor;
    [Token(Token = "0x400F533")]
    [FieldOffset(Offset = "0x34")]
    private int mIconIndex;
    [Token(Token = "0x400F534")]
    [FieldOffset(Offset = "0x38")]
    private string mAbilityName;
    [Token(Token = "0x400F535")]
    [FieldOffset(Offset = "0x3C")]
    private string mAbilityLv;
    [Token(Token = "0x400F536")]
    [FieldOffset(Offset = "0x40")]
    private string mAbilityCaution;
    [Token(Token = "0x400F537")]
    [FieldOffset(Offset = "0x44")]
    private bool mIsMasterAbility;
    [Token(Token = "0x400F538")]
    [FieldOffset(Offset = "0x48")]
    private Dictionary<UnitAbilityPanelModel.VisibleKey, bool> mVisibleInternalDic;
    [Token(Token = "0x400F539")]
    [FieldOffset(Offset = "0x4C")]
    private Dictionary<UnitAbilityPanelModel.VisibleKey, bool> mVisibleExternalDic;

    [Token(Token = "0x170020E9")]
    public bool IsHideMode
    {
      [Token(Token = "0x600E7AB"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170020EA")]
    public UnitAbilityPanelModel.Mode PanelMode
    {
      [Token(Token = "0x600E7AC"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new UnitAbilityPanelModel.Mode();
      }
    }

    [Token(Token = "0x170020EB")]
    public UnitData UnitData
    {
      [Token(Token = "0x600E7AD"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x170020EC")]
    public AbilityData AbilityData
    {
      [Token(Token = "0x600E7AE"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (AbilityData) null;
      }
    }

    [Token(Token = "0x170020ED")]
    public AbilityParam AbilityParam
    {
      [Token(Token = "0x600E7AF"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (AbilityParam) null;
      }
    }

    [Token(Token = "0x170020EE")]
    public int SlotIndex
    {
      [Token(Token = "0x600E7B0"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170020EF")]
    public Color BgImageColor
    {
      [Token(Token = "0x600E7B1"), Address(RVA = "0xAB37E0", Offset = "0xAB25E0", VA = "0x10AB37E0")] get
      {
        return new Color();
      }
    }

    [Token(Token = "0x170020F0")]
    public int IconIndex
    {
      [Token(Token = "0x600E7B2"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170020F1")]
    public string AbilityName
    {
      [Token(Token = "0x600E7B3"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170020F2")]
    public string AbilityLv
    {
      [Token(Token = "0x600E7B4"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170020F3")]
    public string AbilityCaution
    {
      [Token(Token = "0x600E7B5"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E7B6")]
    [Address(RVA = "0xACF910", Offset = "0xACE710", VA = "0x10ACF910")]
    public bool Visible(UnitAbilityPanelModel.VisibleKey key) => new bool();

    [Token(Token = "0x600E7B7")]
    [Address(RVA = "0xACFAF0", Offset = "0xACE8F0", VA = "0x10ACFAF0")]
    public UnitAbilityPanelModel(bool isHide = false)
    {
    }

    [Token(Token = "0x600E7B8")]
    [Address(RVA = "0xACF9A0", Offset = "0xACE7A0", VA = "0x10ACF9A0")]
    public UnitAbilityPanelModel(int slotIndex, bool isHide = false)
    {
    }

    [Token(Token = "0x600E7B9")]
    [Address(RVA = "0x2A68E0", Offset = "0x2A56E0", VA = "0x102A68E0")]
    public void SetSlot(int slotIndex)
    {
    }

    [Token(Token = "0x600E7BA")]
    [Address(RVA = "0xACE210", Offset = "0xACD010", VA = "0x10ACE210")]
    public AbilityData DerivedAbility(AbilityData abilityData) => (AbilityData) null;

    [Token(Token = "0x600E7BB")]
    [Address(RVA = "0xACE530", Offset = "0xACD330", VA = "0x10ACE530")]
    public void Initialize(
      UnitData unitData,
      AbilityData abilityData,
      UnitAbilityPanelModel.Mode mode = UnitAbilityPanelModel.Mode.Empty)
    {
    }

    [Token(Token = "0x600E7BC")]
    [Address(RVA = "0xACE4E0", Offset = "0xACD2E0", VA = "0x10ACE4E0")]
    public void Initialize(
      UnitData unitData,
      AbilityParam abilityParam,
      UnitAbilityPanelModel.Mode mode = UnitAbilityPanelModel.Mode.Empty)
    {
    }

    [Token(Token = "0x600E7BD")]
    [Address(RVA = "0xACECF0", Offset = "0xACDAF0", VA = "0x10ACECF0")]
    public void SetAbilityData(UnitData unitData)
    {
    }

    [Token(Token = "0x600E7BE")]
    [Address(RVA = "0xACE590", Offset = "0xACD390", VA = "0x10ACE590")]
    public void RefreshDisplayData()
    {
    }

    [Token(Token = "0x600E7BF")]
    [Address(RVA = "0xACF360", Offset = "0xACE160", VA = "0x10ACF360")]
    public void SetBgImage()
    {
    }

    [Token(Token = "0x600E7C0")]
    [Address(RVA = "0xACF570", Offset = "0xACE370", VA = "0x10ACF570")]
    public void SetIconIndex()
    {
    }

    [Token(Token = "0x600E7C1")]
    [Address(RVA = "0xACF1D0", Offset = "0xACDFD0", VA = "0x10ACF1D0")]
    public void SetAbilityName()
    {
    }

    [Token(Token = "0x600E7C2")]
    [Address(RVA = "0xACEED0", Offset = "0xACDCD0", VA = "0x10ACEED0")]
    public void SetAbilityEmptyText()
    {
    }

    [Token(Token = "0x600E7C3")]
    [Address(RVA = "0xACEFA0", Offset = "0xACDDA0", VA = "0x10ACEFA0")]
    public void SetAbilityLv()
    {
    }

    [Token(Token = "0x600E7C4")]
    [Address(RVA = "0xACEC60", Offset = "0xACDA60", VA = "0x10ACEC60")]
    public void SetAbilityCaution()
    {
    }

    [Token(Token = "0x600E7C5")]
    [Address(RVA = "0xACF7A0", Offset = "0xACE5A0", VA = "0x10ACF7A0")]
    public void SetLock()
    {
    }

    [Token(Token = "0x600E7C6")]
    [Address(RVA = "0xACE250", Offset = "0xACD050", VA = "0x10ACE250")]
    public void InitVisible(
      Dictionary<UnitAbilityPanelModel.VisibleKey, bool> visibleDic,
      bool isDefault = false)
    {
    }

    [Token(Token = "0x600E7C7")]
    [Address(RVA = "0xACF880", Offset = "0xACE680", VA = "0x10ACF880")]
    public void SetVisible(
      Dictionary<UnitAbilityPanelModel.VisibleKey, bool> visibleDic,
      UnitAbilityPanelModel.VisibleKey key,
      bool isFlag)
    {
    }

    [Token(Token = "0x600E7C8")]
    [Address(RVA = "0xACF710", Offset = "0xACE510", VA = "0x10ACF710")]
    private void SetInternalVisible(UnitAbilityPanelModel.VisibleKey key, bool isFlag)
    {
    }

    [Token(Token = "0x600E7C9")]
    [Address(RVA = "0xACF4E0", Offset = "0xACE2E0", VA = "0x10ACF4E0")]
    public void SetExternalVisible(UnitAbilityPanelModel.VisibleKey key, bool isFlag)
    {
    }

    [Token(Token = "0x20033C9")]
    public enum SlotIndexEnum
    {
      [Token(Token = "0x400F53B")] MainActive,
      [Token(Token = "0x400F53C")] SubActive,
      [Token(Token = "0x400F53D")] Reaction,
      [Token(Token = "0x400F53E")] Support1,
      [Token(Token = "0x400F53F")] Support2,
      [Token(Token = "0x400F540")] Master,
    }

    [Token(Token = "0x20033CA")]
    public enum Mode
    {
      [Token(Token = "0x400F542")] Normal,
      [Token(Token = "0x400F543")] Locked,
      [Token(Token = "0x400F544")] NoSlot,
      [Token(Token = "0x400F545")] Empty,
      [Token(Token = "0x400F546")] SlotMismatch,
      [Token(Token = "0x400F547")] Fixed,
    }

    [Token(Token = "0x20033CB")]
    public enum VisibleKey
    {
      [Token(Token = "0x400F549")] BgImage,
      [Token(Token = "0x400F54A")] BgImageEmpty,
      [Token(Token = "0x400F54B")] Icon,
      [Token(Token = "0x400F54C")] AbilityLock,
      [Token(Token = "0x400F54D")] AbilityName,
      [Token(Token = "0x400F54E")] AbilityEmptyText,
      [Token(Token = "0x400F54F")] AbilityLv,
      [Token(Token = "0x400F550")] AbilityMax,
      [Token(Token = "0x400F551")] AbilityCaution,
    }
  }
}
