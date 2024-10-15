// Decompiled with JetBrains decompiler
// Type: SRPG.Models.ResonanceUnitConfirmWindowModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003387")]
  public class ResonanceUnitConfirmWindowModel
  {
    [Token(Token = "0x400F3CA")]
    [FieldOffset(Offset = "0x8")]
    private UnitData baseUnitdata;
    [Token(Token = "0x400F3CB")]
    [FieldOffset(Offset = "0xC")]
    private UnitData resonanceUnitdata;
    [Token(Token = "0x400F3CC")]
    [FieldOffset(Offset = "0x10")]
    private string descriptionMsg;
    [Token(Token = "0x400F3CD")]
    [FieldOffset(Offset = "0x14")]
    private bool isItemAmount;

    [Token(Token = "0x17001FC4")]
    public UnitData BaseUnitdata
    {
      [Token(Token = "0x600E54C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17001FC5")]
    public UnitData ResonanceUnitdata
    {
      [Token(Token = "0x600E54D"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17001FC6")]
    public bool IsItemAmount
    {
      [Token(Token = "0x600E54E"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001FC7")]
    public string DescriptionMsg
    {
      [Token(Token = "0x600E54F"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E550")]
    [Address(RVA = "0xABFE40", Offset = "0xABEC40", VA = "0x10ABFE40")]
    public void Initialize(UnitData _unitdata, UnitData _resonanceUnitdata)
    {
    }

    [Token(Token = "0x600E551")]
    [Address(RVA = "0xABFC00", Offset = "0xABEA00", VA = "0x10ABFC00")]
    private void InitializeData()
    {
    }

    [Token(Token = "0x600E552")]
    [Address(RVA = "0xABFA80", Offset = "0xABE880", VA = "0x10ABFA80")]
    private bool CheckItemAmount() => new bool();

    [Token(Token = "0x600E553")]
    [Address(RVA = "0xABFE80", Offset = "0xABEC80", VA = "0x10ABFE80")]
    public ResonanceUnitConfirmWindowModel()
    {
    }
  }
}
