// Decompiled with JetBrains decompiler
// Type: SRPG.Models.UnitAwakeModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033D0")]
  public class UnitAwakeModel
  {
    [Token(Token = "0x400F56C")]
    [FieldOffset(Offset = "0x8")]
    private UnitData unitdata;
    [Token(Token = "0x400F56D")]
    [FieldOffset(Offset = "0xC")]
    private int awake;
    [Token(Token = "0x400F56E")]
    [FieldOffset(Offset = "0x10")]
    private int beforePlus;
    [Token(Token = "0x400F56F")]
    private const int icon_elem_num = 5;

    [Token(Token = "0x17002107")]
    public UnitData Unitdata
    {
      [Token(Token = "0x600E7EC"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x600E7ED")]
    [Address(RVA = "0xACFC40", Offset = "0xACEA40", VA = "0x10ACFC40")]
    public int Awake(int index) => new int();

    [Token(Token = "0x600E7EE")]
    [Address(RVA = "0xACFD20", Offset = "0xACEB20", VA = "0x10ACFD20")]
    public int ResonanceAwake(int index) => new int();

    [Token(Token = "0x600E7EF")]
    [Address(RVA = "0xACFCD0", Offset = "0xACEAD0", VA = "0x10ACFCD0")]
    public void Initialize(UnitData _unitdata)
    {
    }

    [Token(Token = "0x600E7F0")]
    [Address(RVA = "0xACFC90", Offset = "0xACEA90", VA = "0x10ACFC90")]
    private void InitializeData()
    {
    }

    [Token(Token = "0x600E7F1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnitAwakeModel()
    {
    }
  }
}
