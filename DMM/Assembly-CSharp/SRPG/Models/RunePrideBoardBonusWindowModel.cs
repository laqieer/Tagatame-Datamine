// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RunePrideBoardBonusWindowModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033AF")]
  public class RunePrideBoardBonusWindowModel
  {
    [Token(Token = "0x400F496")]
    [FieldOffset(Offset = "0x8")]
    private string mTitleText;
    [Token(Token = "0x400F497")]
    [FieldOffset(Offset = "0xC")]
    private string mBonusNumText;
    [Token(Token = "0x400F498")]
    [FieldOffset(Offset = "0x10")]
    private string mAddBonusNumText;
    [Token(Token = "0x400F499")]
    [FieldOffset(Offset = "0x14")]
    private int mAddBonusNum;

    [Token(Token = "0x1700205E")]
    public string TitleText
    {
      [Token(Token = "0x600E6BA"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700205F")]
    public string BonusNumText
    {
      [Token(Token = "0x600E6BB"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002060")]
    public string AddBonusNumText
    {
      [Token(Token = "0x600E6BC"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002061")]
    public int AddBonusNum
    {
      [Token(Token = "0x600E6BD"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600E6BE")]
    [Address(RVA = "0xAC5F10", Offset = "0xAC4D10", VA = "0x10AC5F10")]
    public void Initialize(UnitData _unit_data)
    {
    }

    [Token(Token = "0x600E6BF")]
    [Address(RVA = "0xAC60A0", Offset = "0xAC4EA0", VA = "0x10AC60A0")]
    public void SetAddBonusNum(int _add_num)
    {
    }

    [Token(Token = "0x600E6C0")]
    [Address(RVA = "0xAC6190", Offset = "0xAC4F90", VA = "0x10AC6190")]
    public void SetSubBonusNum(int _sub_num)
    {
    }

    [Token(Token = "0x600E6C1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePrideBoardBonusWindowModel()
    {
    }
  }
}
