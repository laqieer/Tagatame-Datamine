// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RunePrideBoardBonusModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033AC")]
  public class RunePrideBoardBonusModel
  {
    [Token(Token = "0x400F485")]
    [FieldOffset(Offset = "0x8")]
    private RunePrideBoardBonusModel.BonusIconImage mIconImageIndex;
    [Token(Token = "0x400F486")]
    [FieldOffset(Offset = "0xC")]
    private bool mIsImageActive;
    [Token(Token = "0x400F487")]
    [FieldOffset(Offset = "0xD")]
    private bool mIsBonusAnim;
    [Token(Token = "0x400F488")]
    [FieldOffset(Offset = "0x10")]
    private string mBonusNumText;
    [Token(Token = "0x400F489")]
    [FieldOffset(Offset = "0x14")]
    private bool mIsSelect;
    [Token(Token = "0x400F48A")]
    [FieldOffset(Offset = "0x15")]
    private bool mIsDispParameter;
    [Token(Token = "0x400F48B")]
    [FieldOffset(Offset = "0x16")]
    private bool mIsDispPotential;
    [Token(Token = "0x400F48C")]
    [FieldOffset(Offset = "0x17")]
    private bool mIsInteractive;
    [Token(Token = "0x400F48D")]
    [FieldOffset(Offset = "0x18")]
    private bool mIsMask;
    [Token(Token = "0x400F48E")]
    [FieldOffset(Offset = "0x1C")]
    private int mBonusNum;

    [Token(Token = "0x17002051")]
    public RunePrideBoardBonusModel.BonusIconImage IconImageIndex
    {
      [Token(Token = "0x600E6A3"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new RunePrideBoardBonusModel.BonusIconImage();
      }
    }

    [Token(Token = "0x17002052")]
    public bool IsImageActive
    {
      [Token(Token = "0x600E6A4"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002053")]
    public bool IsBonusAnim
    {
      [Token(Token = "0x600E6A5"), Address(RVA = "0x3DA450", Offset = "0x3D9250", VA = "0x103DA450")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002054")]
    public string BonusNumText
    {
      [Token(Token = "0x600E6A6"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002055")]
    public bool IsSelect
    {
      [Token(Token = "0x600E6A7"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002056")]
    public bool IsDispParameter
    {
      [Token(Token = "0x600E6A8"), Address(RVA = "0x39C2B0", Offset = "0x39B0B0", VA = "0x1039C2B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002057")]
    public bool IsDispPotential
    {
      [Token(Token = "0x600E6A9"), Address(RVA = "0x7B1D20", Offset = "0x7B0B20", VA = "0x107B1D20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002058")]
    public bool IsInteractive
    {
      [Token(Token = "0x600E6AA"), Address(RVA = "0xAC5F00", Offset = "0xAC4D00", VA = "0x10AC5F00")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002059")]
    public bool IsMask
    {
      [Token(Token = "0x600E6AB"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E6AC")]
    [Address(RVA = "0xAC5D40", Offset = "0xAC4B40", VA = "0x10AC5D40")]
    public void Initialize(RunePrideBonusParam _param, int _bonus_num)
    {
    }

    [Token(Token = "0x600E6AD")]
    [Address(RVA = "0xAC5EA0", Offset = "0xAC4CA0", VA = "0x10AC5EA0")]
    public void Refresh(int _bonus_num)
    {
    }

    [Token(Token = "0x600E6AE")]
    [Address(RVA = "0xAC5EE0", Offset = "0xAC4CE0", VA = "0x10AC5EE0")]
    public void SetBonusAnim(int _now_bonus_num, int _next_bonus_num)
    {
    }

    [Token(Token = "0x600E6AF")]
    [Address(RVA = "0x357B00", Offset = "0x356900", VA = "0x10357B00")]
    public void SetSelectObjFlag(bool _flag)
    {
    }

    [Token(Token = "0x600E6B0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePrideBoardBonusModel()
    {
    }

    [Token(Token = "0x20033AD")]
    public enum BonusIconImage
    {
      [Token(Token = "0x400F490")] OFF,
      [Token(Token = "0x400F491")] ON,
    }
  }
}
