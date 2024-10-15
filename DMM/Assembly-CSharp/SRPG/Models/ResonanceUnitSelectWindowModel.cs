// Decompiled with JetBrains decompiler
// Type: SRPG.Models.ResonanceUnitSelectWindowModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003388")]
  public class ResonanceUnitSelectWindowModel
  {
    [Token(Token = "0x400F3CE")]
    [FieldOffset(Offset = "0x8")]
    private UnitModel resonanceUnitModel;
    [Token(Token = "0x400F3CF")]
    [FieldOffset(Offset = "0xC")]
    private string invalidResonanceMsg;

    [Token(Token = "0x17001FC8")]
    public UnitModel ResonanceUnitModel
    {
      [Token(Token = "0x600E554"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (UnitModel) null;
      }
    }

    [Token(Token = "0x17001FC9")]
    public string InvalidResonanceMessage
    {
      [Token(Token = "0x600E555"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E556")]
    [Address(RVA = "0xAC0130", Offset = "0xABEF30", VA = "0x10AC0130")]
    public void Initialize(UnitModel _resonanceUnitModel)
    {
    }

    [Token(Token = "0x600E557")]
    [Address(RVA = "0xABFED0", Offset = "0xABECD0", VA = "0x10ABFED0")]
    private void InitializeData()
    {
    }

    [Token(Token = "0x600E558")]
    [Address(RVA = "0xAC0160", Offset = "0xABEF60", VA = "0x10AC0160")]
    public ResonanceUnitSelectWindowModel()
    {
    }
  }
}
