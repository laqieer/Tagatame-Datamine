// Decompiled with JetBrains decompiler
// Type: SRPG.UnitGaugeMark
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C26")]
  [AddComponentMenu("UI/UnitGaugeMark")]
  public class UnitGaugeMark : MonoBehaviour
  {
    [Token(Token = "0x400DA76")]
    [FieldOffset(Offset = "0xC")]
    private UnitGaugeMark.EGemIcon mGemIconType;
    [Token(Token = "0x400DA77")]
    [FieldOffset(Offset = "0x10")]
    public string EndAnimationName;
    [Token(Token = "0x400DA78")]
    [FieldOffset(Offset = "0x14")]
    public string EndTriggerName;
    [Token(Token = "0x400DA79")]
    [FieldOffset(Offset = "0x18")]
    public int EndTriggerValue;
    [Token(Token = "0x400DA7A")]
    [FieldOffset(Offset = "0x1C")]
    public UnitGauge UnitGauge;
    [Token(Token = "0x400DA7B")]
    [FieldOffset(Offset = "0x20")]
    public UnitGaugeMark.EMarkType MarkType;
    [Token(Token = "0x400DA7C")]
    [FieldOffset(Offset = "0x24")]
    public GameObject MapChest;
    [Token(Token = "0x400DA7D")]
    [FieldOffset(Offset = "0x28")]
    public UnitGaugeGemIcon MapGem;
    [Token(Token = "0x400DA7E")]
    [FieldOffset(Offset = "0x2C")]
    private List<UnitGaugeMark.ObjectAnim> mActiveMarkLists;
    [Token(Token = "0x400DA7F")]
    [FieldOffset(Offset = "0x30")]
    private bool mIsGaugeUpdate;
    [Token(Token = "0x400DA80")]
    [FieldOffset(Offset = "0x31")]
    private bool mIsUnitDead;
    [Token(Token = "0x400DA81")]
    [FieldOffset(Offset = "0x32")]
    private bool mIsUseSkill;

    [Token(Token = "0x17001B0D")]
    public UnitGaugeMark.EGemIcon GemIconType
    {
      [Token(Token = "0x600CC69"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new UnitGaugeMark.EGemIcon();
      }
    }

    [Token(Token = "0x17001B0E")]
    public bool IsGaugeUpdate
    {
      [Token(Token = "0x600CC6A"), Address(RVA = "0x380080", Offset = "0x37EE80", VA = "0x10380080")] get
      {
        return new bool();
      }
      [Token(Token = "0x600CC6B"), Address(RVA = "0x3A1250", Offset = "0x3A0050", VA = "0x103A1250")] set
      {
      }
    }

    [Token(Token = "0x17001B0F")]
    public bool IsUnitDead
    {
      [Token(Token = "0x600CC6C"), Address(RVA = "0x7F55A0", Offset = "0x7F43A0", VA = "0x107F55A0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600CC6D"), Address(RVA = "0x9728A0", Offset = "0x9716A0", VA = "0x109728A0")] set
      {
      }
    }

    [Token(Token = "0x17001B10")]
    public bool IsUseSkill
    {
      [Token(Token = "0x600CC6E"), Address(RVA = "0x972890", Offset = "0x971690", VA = "0x10972890")] get
      {
        return new bool();
      }
      [Token(Token = "0x600CC6F"), Address(RVA = "0x9728B0", Offset = "0x9716B0", VA = "0x109728B0")] set
      {
      }
    }

    [Token(Token = "0x600CC70")]
    [Address(RVA = "0x971F50", Offset = "0x970D50", VA = "0x10971F50")]
    public bool IsUpdatable(UnitGaugeMark.EMarkType MarkType) => new bool();

    [Token(Token = "0x600CC71")]
    [Address(RVA = "0x971F30", Offset = "0x970D30", VA = "0x10971F30")]
    private int GetUnitGaugeMode() => new int();

    [Token(Token = "0x600CC72")]
    [Address(RVA = "0x971C80", Offset = "0x970A80", VA = "0x10971C80")]
    private GameObject CreateMarkObject() => (GameObject) null;

    [Token(Token = "0x600CC73")]
    [Address(RVA = "0x972250", Offset = "0x971050", VA = "0x10972250")]
    private void SetEndAnimation(UnitGaugeMark.ObjectAnim mark)
    {
    }

    [Token(Token = "0x600CC74")]
    [Address(RVA = "0x972110", Offset = "0x970F10", VA = "0x10972110")]
    public void SetEndAnimation(UnitGaugeMark.EMarkType Type)
    {
    }

    [Token(Token = "0x600CC75")]
    [Address(RVA = "0x971F80", Offset = "0x970D80", VA = "0x10971F80")]
    public void SetEndAnimationAll()
    {
    }

    [Token(Token = "0x600CC76")]
    [Address(RVA = "0x971C30", Offset = "0x970A30", VA = "0x10971C30")]
    public void ChangeAnimationByUnitType(EUnitType Type)
    {
    }

    [Token(Token = "0x600CC77")]
    [Address(RVA = "0x9722D0", Offset = "0x9710D0", VA = "0x109722D0")]
    public void SetGemIcon(EEventGimmick EventType)
    {
    }

    [Token(Token = "0x600CC78")]
    [Address(RVA = "0x971E90", Offset = "0x970C90", VA = "0x10971E90")]
    public void DeleteIconAll()
    {
    }

    [Token(Token = "0x600CC79")]
    [Address(RVA = "0x972340", Offset = "0x971140", VA = "0x10972340")]
    private void Update()
    {
    }

    [Token(Token = "0x600CC7A")]
    [Address(RVA = "0x972730", Offset = "0x971530", VA = "0x10972730")]
    public UnitGaugeMark()
    {
    }

    [Token(Token = "0x2002C27")]
    private class ObjectAnim
    {
      [Token(Token = "0x400DA82")]
      [FieldOffset(Offset = "0x8")]
      public GameObject Object;
      [Token(Token = "0x400DA83")]
      [FieldOffset(Offset = "0xC")]
      public Animator Animator;
      [Token(Token = "0x400DA84")]
      [FieldOffset(Offset = "0x10")]
      public bool IsEnd;
      [Token(Token = "0x400DA85")]
      [FieldOffset(Offset = "0x14")]
      public UnitGaugeMark.EMarkType MarkType;
      [Token(Token = "0x400DA86")]
      [FieldOffset(Offset = "0x18")]
      public UnitGaugeMark.EGemIcon GemIconType;

      [Token(Token = "0x600CC7C")]
      [Address(RVA = "0x967640", Offset = "0x966440", VA = "0x10967640")]
      public ObjectAnim(
        GameObject Object,
        Animator Animator,
        UnitGaugeMark.EMarkType mark_type,
        UnitGaugeMark.EGemIcon gem_icon)
      {
      }

      [Token(Token = "0x600CC7D")]
      [Address(RVA = "0x9675B0", Offset = "0x9663B0", VA = "0x109675B0")]
      public void Release()
      {
      }
    }

    [Token(Token = "0x2002C28")]
    [Serializable]
    public enum EMarkType
    {
      [Token(Token = "0x400DA88")] None,
      [Token(Token = "0x400DA89")] MapChest,
      [Token(Token = "0x400DA8A")] MapGem,
    }

    [Token(Token = "0x2002C29")]
    [Serializable]
    public enum EGemIcon
    {
      [Token(Token = "0x400DA8C")] Normal,
      [Token(Token = "0x400DA8D")] Heal,
      [Token(Token = "0x400DA8E")] CriUp,
      [Token(Token = "0x400DA8F")] MovUp,
    }
  }
}
