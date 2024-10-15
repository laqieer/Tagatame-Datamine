// Decompiled with JetBrains decompiler
// Type: SRPG.Models.TruthEquipmentAddStatusModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033C3")]
  public class TruthEquipmentAddStatusModel
  {
    [Token(Token = "0x400F515")]
    [FieldOffset(Offset = "0x8")]
    private BaseStatus _baseStatusAdd;
    [Token(Token = "0x400F516")]
    [FieldOffset(Offset = "0xC")]
    private BaseStatus _baseStatusScale;
    [Token(Token = "0x400F517")]
    [FieldOffset(Offset = "0x10")]
    private bool _isGetAbility;
    [Token(Token = "0x400F518")]
    [FieldOffset(Offset = "0x11")]
    private bool _isOverwriteAbility;

    [Token(Token = "0x170020DC")]
    public BaseStatus BaseStatusAdd
    {
      [Token(Token = "0x600E78B"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (BaseStatus) null;
      }
    }

    [Token(Token = "0x170020DD")]
    public BaseStatus BaseStatusScale
    {
      [Token(Token = "0x600E78C"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (BaseStatus) null;
      }
    }

    [Token(Token = "0x170020DE")]
    public bool IsGetAbility
    {
      [Token(Token = "0x600E78D"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170020DF")]
    public bool IsOverwriteAbility
    {
      [Token(Token = "0x600E78E"), Address(RVA = "0x3E6E30", Offset = "0x3E5C30", VA = "0x103E6E30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E78F")]
    [Address(RVA = "0xACD4C0", Offset = "0xACC2C0", VA = "0x10ACD4C0")]
    public void Initialize(UnitData unitData, int level)
    {
    }

    [Token(Token = "0x600E790")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TruthEquipmentAddStatusModel()
    {
    }
  }
}
