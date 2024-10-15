// Decompiled with JetBrains decompiler
// Type: SRPG.Models.UnitLeaderSkillModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033D1")]
  public class UnitLeaderSkillModel
  {
    [Token(Token = "0x400F570")]
    [FieldOffset(Offset = "0x8")]
    private UnitData _unitdata;
    [Token(Token = "0x400F571")]
    [FieldOffset(Offset = "0xC")]
    private SkillParam _skill;

    [Token(Token = "0x17002108")]
    public bool IsChangeLeaderSkillButton
    {
      [Token(Token = "0x600E7F2"), Address(RVA = "0xAD0A60", Offset = "0xACF860", VA = "0x10AD0A60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002109")]
    public int LeaderSkillBGImageIndex
    {
      [Token(Token = "0x600E7F3"), Address(RVA = "0xAD0AB0", Offset = "0xACF8B0", VA = "0x10AD0AB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700210A")]
    public string Name
    {
      [Token(Token = "0x600E7F4"), Address(RVA = "0xAD0AE0", Offset = "0xACF8E0", VA = "0x10AD0AE0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700210B")]
    public string Expr
    {
      [Token(Token = "0x600E7F5"), Address(RVA = "0xAD0A00", Offset = "0xACF800", VA = "0x10AD0A00")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E7F6")]
    [Address(RVA = "0xAD0900", Offset = "0xACF700", VA = "0x10AD0900")]
    public void Initialize(UnitData unitdata)
    {
    }

    [Token(Token = "0x600E7F7")]
    [Address(RVA = "0xAD0810", Offset = "0xACF610", VA = "0x10AD0810")]
    private void InitializeData()
    {
    }

    [Token(Token = "0x600E7F8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnitLeaderSkillModel()
    {
    }
  }
}
