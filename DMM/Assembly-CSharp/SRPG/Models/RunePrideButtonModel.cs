// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RunePrideButtonModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033B0")]
  public class RunePrideButtonModel
  {
    [Token(Token = "0x400F49A")]
    [FieldOffset(Offset = "0x8")]
    private bool mIsObjDisp;
    [Token(Token = "0x400F49B")]
    [FieldOffset(Offset = "0x9")]
    private bool mIsObjTimeDisp;
    [Token(Token = "0x400F49C")]
    [FieldOffset(Offset = "0xA")]
    private bool mIsLockDisp;
    [Token(Token = "0x400F49D")]
    private const int START_PANEL = 0;

    [Token(Token = "0x17002062")]
    public bool IsObjDisp
    {
      [Token(Token = "0x600E6C2"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002063")]
    public bool IsObjTimeDisp
    {
      [Token(Token = "0x600E6C3"), Address(RVA = "0x34B080", Offset = "0x349E80", VA = "0x1034B080")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002064")]
    public bool IsLockDisp
    {
      [Token(Token = "0x600E6C4"), Address(RVA = "0x34B070", Offset = "0x349E70", VA = "0x1034B070")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E6C5")]
    [Address(RVA = "0xAC6280", Offset = "0xAC5080", VA = "0x10AC6280")]
    public void Initialize(UnitData _unit_data)
    {
    }

    [Token(Token = "0x600E6C6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePrideButtonModel()
    {
    }
  }
}
