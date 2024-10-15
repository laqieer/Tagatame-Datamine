// Decompiled with JetBrains decompiler
// Type: SRPG.Models.UnitToolTipWindowExModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033DD")]
  public class UnitToolTipWindowExModel
  {
    [Token(Token = "0x400F5A6")]
    [FieldOffset(Offset = "0x8")]
    private OLong UnitEmpty;
    [Token(Token = "0x400F5A7")]
    [FieldOffset(Offset = "0x30")]
    private OLong mUnitId;
    [Token(Token = "0x400F5A8")]
    [FieldOffset(Offset = "0x58")]
    private UnitData mData;
    [Token(Token = "0x400F5A9")]
    [FieldOffset(Offset = "0x5C")]
    private bool mEditMode;
    [Token(Token = "0x400F5AA")]
    [FieldOffset(Offset = "0x5D")]
    private bool mHideFlag;
    [Token(Token = "0x400F5AB")]
    [FieldOffset(Offset = "0x5E")]
    private bool mEditModeDefault;
    [Token(Token = "0x400F5AC")]
    [FieldOffset(Offset = "0x60")]
    private eOverWritePartyType mPartyOverWriteType;
    [Token(Token = "0x400F5AD")]
    [FieldOffset(Offset = "0x64")]
    private bool mIsAutoSkillButtonVisible;
    [Token(Token = "0x400F5AE")]
    [FieldOffset(Offset = "0x65")]
    private bool mIsAutoSkillButtonEnable;
    [Token(Token = "0x400F5AF")]
    [FieldOffset(Offset = "0x66")]
    private bool mIsRunesButtonVisible;
    [Token(Token = "0x400F5B0")]
    [FieldOffset(Offset = "0x67")]
    private bool mIsRunesButtonEnable;
    [Token(Token = "0x400F5B1")]
    [FieldOffset(Offset = "0x68")]
    private bool mGetUnitIDForData;
    [Token(Token = "0x400F5B2")]
    [FieldOffset(Offset = "0x6C")]
    private Dictionary<string, bool> mHideSetting;

    [Token(Token = "0x17002145")]
    public OLong UnitId
    {
      [Token(Token = "0x600E857"), Address(RVA = "0xAD4EF0", Offset = "0xAD3CF0", VA = "0x10AD4EF0")] get
      {
        return new OLong();
      }
    }

    [Token(Token = "0x17002146")]
    public UnitData Data
    {
      [Token(Token = "0x600E858"), Address(RVA = "0x349160", Offset = "0x347F60", VA = "0x10349160")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17002147")]
    public bool EditMode
    {
      [Token(Token = "0x600E859"), Address(RVA = "0x685520", Offset = "0x684320", VA = "0x10685520")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002148")]
    public bool HideFlag
    {
      [Token(Token = "0x600E85A"), Address(RVA = "0xAD4ED0", Offset = "0xAD3CD0", VA = "0x10AD4ED0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002149")]
    public eOverWritePartyType PartyOverWriteType
    {
      [Token(Token = "0x600E85B"), Address(RVA = "0x2B5EA0", Offset = "0x2B4CA0", VA = "0x102B5EA0")] get
      {
        return new eOverWritePartyType();
      }
    }

    [Token(Token = "0x1700214A")]
    public bool IsAutoSkillButtonVisible
    {
      [Token(Token = "0x600E85C"), Address(RVA = "0x8D3C80", Offset = "0x8D2A80", VA = "0x108D3C80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700214B")]
    public bool IsAutoSkillButtonEnable
    {
      [Token(Token = "0x600E85D"), Address(RVA = "0x2B79D0", Offset = "0x2B67D0", VA = "0x102B79D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700214C")]
    public bool IsRunesButtonVisible
    {
      [Token(Token = "0x600E85E"), Address(RVA = "0x2B79C0", Offset = "0x2B67C0", VA = "0x102B79C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700214D")]
    public bool IsRunesButtonEnable
    {
      [Token(Token = "0x600E85F"), Address(RVA = "0xAD4EE0", Offset = "0xAD3CE0", VA = "0x10AD4EE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700214E")]
    public bool GetUnitIDForData
    {
      [Token(Token = "0x600E860"), Address(RVA = "0x352390", Offset = "0x351190", VA = "0x10352390")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E861")]
    [Address(RVA = "0xAD42F0", Offset = "0xAD30F0", VA = "0x10AD42F0")]
    public void Initialize(OLong uid)
    {
    }

    [Token(Token = "0x600E862")]
    [Address(RVA = "0xAD41E0", Offset = "0xAD2FE0", VA = "0x10AD41E0")]
    public void Initialize(UnitData unitData)
    {
    }

    [Token(Token = "0x600E863")]
    [Address(RVA = "0xAD4AC0", Offset = "0xAD38C0", VA = "0x10AD4AC0")]
    public void Setup()
    {
    }

    [Token(Token = "0x600E864")]
    [Address(RVA = "0xAD48F0", Offset = "0xAD36F0", VA = "0x10AD48F0")]
    public void SetupUnitData()
    {
    }

    [Token(Token = "0x600E865")]
    [Address(RVA = "0xAD4650", Offset = "0xAD3450", VA = "0x10AD4650")]
    public void SetOverWritePartyType(eOverWritePartyType type)
    {
    }

    [Token(Token = "0x600E866")]
    [Address(RVA = "0x352470", Offset = "0x351270", VA = "0x10352470")]
    public void SetUnitIdForDataFlag(bool isflag)
    {
    }

    [Token(Token = "0x600E867")]
    [Address(RVA = "0xAD43B0", Offset = "0xAD31B0", VA = "0x10AD43B0")]
    public void SetEditModeDefault(bool isflag)
    {
    }

    [Token(Token = "0x600E868")]
    [Address(RVA = "0xAD4460", Offset = "0xAD3260", VA = "0x10AD4460")]
    public void SetHideModeSetting(string key, bool isflag)
    {
    }

    [Token(Token = "0x600E869")]
    [Address(RVA = "0xAD4450", Offset = "0xAD3250", VA = "0x10AD4450")]
    public void SetHideFlag(bool isHide)
    {
    }

    [Token(Token = "0x600E86A")]
    [Address(RVA = "0xAD46D0", Offset = "0xAD34D0", VA = "0x10AD46D0")]
    public void SetVisibleAutoSkillButton(bool isFlag = false)
    {
    }

    [Token(Token = "0x600E86B")]
    [Address(RVA = "0xAD4550", Offset = "0xAD3350", VA = "0x10AD4550")]
    public void SetIntaractableAutoSkillButton(bool isFlag = false)
    {
    }

    [Token(Token = "0x600E86C")]
    [Address(RVA = "0xAD47B0", Offset = "0xAD35B0", VA = "0x10AD47B0")]
    public void SetVisibleRuneButton(bool isFlag = false)
    {
    }

    [Token(Token = "0x600E86D")]
    [Address(RVA = "0xAD4570", Offset = "0xAD3370", VA = "0x10AD4570")]
    public void SetIntaractableRuneButton(bool isFlag = false)
    {
    }

    [Token(Token = "0x600E86E")]
    [Address(RVA = "0xAD43C0", Offset = "0xAD31C0", VA = "0x10AD43C0")]
    private void SetEditMode(bool isEdit = true)
    {
    }

    [Token(Token = "0x600E86F")]
    [Address(RVA = "0xAD4180", Offset = "0xAD2F80", VA = "0x10AD4180")]
    public bool GetHideSetting(string key) => new bool();

    [Token(Token = "0x600E870")]
    [Address(RVA = "0xAD4E20", Offset = "0xAD3C20", VA = "0x10AD4E20")]
    public UnitToolTipWindowExModel()
    {
    }
  }
}
