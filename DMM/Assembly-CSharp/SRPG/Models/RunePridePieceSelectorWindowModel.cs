// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RunePridePieceSelectorWindowModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033B6")]
  public class RunePridePieceSelectorWindowModel
  {
    [Token(Token = "0x400F4D0")]
    [FieldOffset(Offset = "0x8")]
    protected string mTitleText;
    [Token(Token = "0x400F4D1")]
    [FieldOffset(Offset = "0xC")]
    protected bool mIsDispClearBtn;
    [Token(Token = "0x400F4D2")]
    [FieldOffset(Offset = "0xD")]
    protected bool mIsDispMaxBtn;
    [Token(Token = "0x400F4D3")]
    [FieldOffset(Offset = "0xE")]
    protected bool mIsDispCancelBtn;
    [Token(Token = "0x400F4D4")]
    [FieldOffset(Offset = "0xF")]
    protected bool mIsDispOkBtn;
    [Token(Token = "0x400F4D5")]
    [FieldOffset(Offset = "0x10")]
    protected int mNeedAmount;
    [Token(Token = "0x400F4D6")]
    [FieldOffset(Offset = "0x14")]
    protected int mSelectAmount;
    [Token(Token = "0x400F4D7")]
    [FieldOffset(Offset = "0x18")]
    protected Color mSelectAmountTextColor;
    [Token(Token = "0x400F4D8")]
    [FieldOffset(Offset = "0x28")]
    protected bool mIsEnableOkBtn;
    [Token(Token = "0x400F4D9")]
    [FieldOffset(Offset = "0x29")]
    protected bool mIsEnableConfigBtn;

    [Token(Token = "0x1700208C")]
    public string TitleText
    {
      [Token(Token = "0x600E70A"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700208D")]
    public bool IsDispClearBtn
    {
      [Token(Token = "0x600E70B"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700208E")]
    public bool IsDispMaxBtn
    {
      [Token(Token = "0x600E70C"), Address(RVA = "0x3DA450", Offset = "0x3D9250", VA = "0x103DA450")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700208F")]
    public bool IsDispCancelBtn
    {
      [Token(Token = "0x600E70D"), Address(RVA = "0x3E7F60", Offset = "0x3E6D60", VA = "0x103E7F60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002090")]
    public bool IsDispOkBtn
    {
      [Token(Token = "0x600E70E"), Address(RVA = "0x3E7F50", Offset = "0x3E6D50", VA = "0x103E7F50")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002091")]
    public int NeedAmount
    {
      [Token(Token = "0x600E70F"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002092")]
    public int SelectAmount
    {
      [Token(Token = "0x600E710"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002093")]
    public Color SelectAmountTextColor
    {
      [Token(Token = "0x600E711"), Address(RVA = "0xAC70F0", Offset = "0xAC5EF0", VA = "0x10AC70F0")] get
      {
        return new Color();
      }
    }

    [Token(Token = "0x17002094")]
    public bool IsEnableOkBtn
    {
      [Token(Token = "0x600E712"), Address(RVA = "0x34F470", Offset = "0x34E270", VA = "0x1034F470")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002095")]
    public bool IsEnableConfigBtn
    {
      [Token(Token = "0x600E713"), Address(RVA = "0x3550A0", Offset = "0x353EA0", VA = "0x103550A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E714")]
    [Address(RVA = "0xAC6E30", Offset = "0xAC5C30", VA = "0x10AC6E30")]
    public void Init(int need_num, int select_amount, int slot_state, BaseParameterData parameter)
    {
    }

    [Token(Token = "0x600E715")]
    [Address(RVA = "0xAC7090", Offset = "0xAC5E90", VA = "0x10AC7090")]
    public RunePridePieceSelectorWindowModel()
    {
    }
  }
}
