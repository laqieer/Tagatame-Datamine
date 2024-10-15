// Decompiled with JetBrains decompiler
// Type: SRPG.Models.UnitStatusAwakeModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033DA")]
  public class UnitStatusAwakeModel
  {
    [Token(Token = "0x400F588")]
    [FieldOffset(Offset = "0x8")]
    private UnitData mTargetUnit;
    [Token(Token = "0x400F589")]
    [FieldOffset(Offset = "0xC")]
    private UnitModel mUnitModel;
    [Token(Token = "0x400F58A")]
    [FieldOffset(Offset = "0x10")]
    private int mStatusAwakeLimit;
    [Token(Token = "0x400F58B")]
    [FieldOffset(Offset = "0x14")]
    private string mStatusAwakeItem;
    [Token(Token = "0x400F58C")]
    [FieldOffset(Offset = "0x18")]
    private bool mIsUseUnitFlag;
    [Token(Token = "0x400F58D")]
    [FieldOffset(Offset = "0x1C")]
    private string mExplainText;

    [Token(Token = "0x17002138")]
    public UnitData TargetUnit
    {
      [Token(Token = "0x600E840"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17002139")]
    public UnitModel UnitModelData
    {
      [Token(Token = "0x600E841"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (UnitModel) null;
      }
    }

    [Token(Token = "0x1700213A")]
    public string GetJobName
    {
      [Token(Token = "0x600E842"), Address(RVA = "0xAD3280", Offset = "0xAD2080", VA = "0x10AD3280")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700213B")]
    public int GetUnitHP
    {
      [Token(Token = "0x600E843"), Address(RVA = "0xAD3300", Offset = "0xAD2100", VA = "0x10AD3300")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700213C")]
    public int StatusAwakeNow
    {
      [Token(Token = "0x600E844"), Address(RVA = "0xAD33B0", Offset = "0xAD21B0", VA = "0x10AD33B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700213D")]
    public int StatusAwakeLimit
    {
      [Token(Token = "0x600E845"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700213E")]
    public string StatusAwakeItem
    {
      [Token(Token = "0x600E846"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700213F")]
    public bool IsStatusAwakeLimit
    {
      [Token(Token = "0x600E847"), Address(RVA = "0xAD3390", Offset = "0xAD2190", VA = "0x10AD3390")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002140")]
    public bool IsUseUnitFlag
    {
      [Token(Token = "0x600E848"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002141")]
    public string ExplainText
    {
      [Token(Token = "0x600E849"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E84A")]
    [Address(RVA = "0xAD2FB0", Offset = "0xAD1DB0", VA = "0x10AD2FB0")]
    public void Initialize(UnitData unit)
    {
    }

    [Token(Token = "0x600E84B")]
    [Address(RVA = "0xAD3220", Offset = "0xAD2020", VA = "0x10AD3220")]
    public UnitStatusAwakeModel()
    {
    }
  }
}
