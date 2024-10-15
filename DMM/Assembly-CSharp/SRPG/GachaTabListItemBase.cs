// Decompiled with JetBrains decompiler
// Type: SRPG.GachaTabListItemBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002455")]
  public class GachaTabListItemBase : MonoBehaviour
  {
    [Token(Token = "0x400A52B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    protected ExhibitList mExhibitList;
    [Token(Token = "0x400A52C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    protected SRPG_Button mButton;
    [Token(Token = "0x400A52D")]
    [FieldOffset(Offset = "0x14")]
    protected GachaTabListItemBaseModel mBaseModel;
    [Token(Token = "0x400A52E")]
    [FieldOffset(Offset = "0x18")]
    protected int mListIndex;
    [Token(Token = "0x400A52F")]
    [FieldOffset(Offset = "0x1C")]
    private GachaWindow.GachaTabCategory mTabCategory;
    [Token(Token = "0x400A530")]
    [FieldOffset(Offset = "0x1D")]
    protected bool mIsInteractable;
    [Token(Token = "0x400A531")]
    [FieldOffset(Offset = "0x20")]
    private GachaTopParamNew param;

    [Token(Token = "0x17001635")]
    public int ListIndex
    {
      [Token(Token = "0x6009EC7"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001636")]
    public GachaWindow.GachaTabCategory TabCategory
    {
      [Token(Token = "0x6009EC8"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new GachaWindow.GachaTabCategory();
      }
    }

    [Token(Token = "0x17001637")]
    public bool IsInteractable
    {
      [Token(Token = "0x6009EC9"), Address(RVA = "0x5EDE50", Offset = "0x5ECC50", VA = "0x105EDE50")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001638")]
    public bool IsValidParam
    {
      [Token(Token = "0x6009ECA"), Address(RVA = "0x5BCAC0", Offset = "0x5BB8C0", VA = "0x105BCAC0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001639")]
    public bool IsParamEnabled
    {
      [Token(Token = "0x6009ECB"), Address(RVA = "0x613D20", Offset = "0x612B20", VA = "0x10613D20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700163A")]
    public bool IsParamDisabled
    {
      [Token(Token = "0x6009ECC"), Address(RVA = "0x613D00", Offset = "0x612B00", VA = "0x10613D00")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6009ECD")]
    [Address(RVA = "0x6138B0", Offset = "0x6126B0", VA = "0x106138B0", Slot = "4")]
    public virtual void Initialize(
      GachaTabListItemBase.GachaTabListItemBaseSetupData data)
    {
    }

    [Token(Token = "0x6009ECE")]
    [Address(RVA = "0x613A60", Offset = "0x612860", VA = "0x10613A60", Slot = "5")]
    protected virtual void SetExhibit(
      GachaTabListItemBase.GachaTabListItemBaseSetupData data)
    {
    }

    [Token(Token = "0x6009ECF")]
    [Address(RVA = "0x613C40", Offset = "0x612A40", VA = "0x10613C40")]
    public void TabChange(bool isActive, bool isChangeEnabled = true)
    {
    }

    [Token(Token = "0x6009ED0")]
    [Address(RVA = "0x613BE0", Offset = "0x6129E0", VA = "0x10613BE0")]
    public void SwitchTabEnabled(bool isEnable)
    {
    }

    [Token(Token = "0x6009ED1")]
    [Address(RVA = "0x613B80", Offset = "0x612980", VA = "0x10613B80")]
    public void SetFirstSibling()
    {
    }

    [Token(Token = "0x6009ED2")]
    [Address(RVA = "0x613BB0", Offset = "0x6129B0", VA = "0x10613BB0")]
    public void SetLastSibling()
    {
    }

    [Token(Token = "0x6009ED3")]
    [Address(RVA = "0x613CD0", Offset = "0x612AD0", VA = "0x10613CD0")]
    public GachaTabListItemBase()
    {
    }

    [Token(Token = "0x2002456")]
    public struct GachaTabListItemBaseSetupData
    {
      [Token(Token = "0x400A532")]
      [FieldOffset(Offset = "0x0")]
      public GachaTopParamNew Param;
      [Token(Token = "0x400A533")]
      [FieldOffset(Offset = "0x4")]
      public GachaWindow.GachaTabCategory TabCategory;
      [Token(Token = "0x400A534")]
      [FieldOffset(Offset = "0x8")]
      public Action<GachaTabListItemBase, GachaWindow.GachaTabCategory, int> TabChangeCallback;
      [Token(Token = "0x400A535")]
      [FieldOffset(Offset = "0xC")]
      public int TabIndex;
      [Token(Token = "0x400A536")]
      [FieldOffset(Offset = "0x10")]
      public bool IsSibling;
      [Token(Token = "0x400A537")]
      [FieldOffset(Offset = "0x11")]
      public bool IsBadgeEnable;

      [Token(Token = "0x6009ED4")]
      [Address(RVA = "0x613870", Offset = "0x612670", VA = "0x10613870")]
      public GachaTabListItemBaseSetupData(
        GachaTopParamNew param,
        GachaWindow.GachaTabCategory tabCategory,
        Action<GachaTabListItemBase, GachaWindow.GachaTabCategory, int> tabChangeCallback,
        int tabIndex = -1,
        bool isSibling = true,
        bool isBadgeEnable = true)
      {
      }
    }
  }
}
