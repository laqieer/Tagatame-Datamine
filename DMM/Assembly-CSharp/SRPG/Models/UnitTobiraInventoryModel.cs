// Decompiled with JetBrains decompiler
// Type: SRPG.Models.UnitTobiraInventoryModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033C1")]
  public class UnitTobiraInventoryModel
  {
    [Token(Token = "0x400F50B")]
    [FieldOffset(Offset = "0x8")]
    private UnitData unitdata;
    [Token(Token = "0x400F50C")]
    [FieldOffset(Offset = "0xC")]
    private UnitModel unitModel;
    [Token(Token = "0x400F50D")]
    [FieldOffset(Offset = "0x10")]
    private ResonanceParam resonanceParam;
    [Token(Token = "0x400F50E")]
    [FieldOffset(Offset = "0x14")]
    private TobiraData tobiraData;

    [Token(Token = "0x170020D0")]
    public UnitData Unitdata
    {
      [Token(Token = "0x600E779"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x170020D1")]
    public UnitModel UnitModel
    {
      [Token(Token = "0x600E77A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (UnitModel) null;
      }
    }

    [Token(Token = "0x170020D2")]
    public ResonanceParam ResonanceParam
    {
      [Token(Token = "0x600E77B"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (ResonanceParam) null;
      }
    }

    [Token(Token = "0x170020D3")]
    public bool IsTobiraMaxLv
    {
      [Token(Token = "0x600E77C"), Address(RVA = "0xAD3FB0", Offset = "0xAD2DB0", VA = "0x10AD3FB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E77D")]
    [Address(RVA = "0xAD3E60", Offset = "0xAD2C60", VA = "0x10AD3E60")]
    public void Initialize(UnitData _unitdata, TobiraData _tobiraData)
    {
    }

    [Token(Token = "0x170020D4")]
    public TobiraData SetTobiraData
    {
      [Token(Token = "0x600E77E"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] set
      {
      }
    }

    [Token(Token = "0x600E77F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnitTobiraInventoryModel()
    {
    }
  }
}
