// Decompiled with JetBrains decompiler
// Type: SRPG.Models.PickBanUnitModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003302")]
  public class PickBanUnitModel
  {
    [Token(Token = "0x400F00F")]
    [FieldOffset(Offset = "0x8")]
    private bool isLock;
    [Token(Token = "0x400F010")]
    [FieldOffset(Offset = "0xC")]
    private int index;
    [Token(Token = "0x400F011")]
    [FieldOffset(Offset = "0x10")]
    private UnitData unitdata;

    [Token(Token = "0x17001D1A")]
    public bool IsLock
    {
      [Token(Token = "0x600DFFB"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
      [Token(Token = "0x600DFFC"), Address(RVA = "0x3011A0", Offset = "0x2FFFA0", VA = "0x103011A0")] set
      {
      }
    }

    [Token(Token = "0x17001D1B")]
    public int Index
    {
      [Token(Token = "0x600DFFD"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D1C")]
    public UnitData Unitdata
    {
      [Token(Token = "0x600DFFE"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x600DFFF")]
    [Address(RVA = "0xAB3A50", Offset = "0xAB2850", VA = "0x10AB3A50")]
    public void Initialize(UnitData _unitdata, int _index)
    {
    }

    [Token(Token = "0x600E000")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PickBanUnitModel()
    {
    }
  }
}
