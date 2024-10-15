// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideBonusData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CF5")]
  [MessagePackObject(true)]
  public class RunePrideBonusData
  {
    [Token(Token = "0x4007177")]
    [FieldOffset(Offset = "0x8")]
    private string draw_name;
    [Token(Token = "0x4007178")]
    [FieldOffset(Offset = "0xC")]
    private ParamTypes type;
    [Token(Token = "0x4007179")]
    [FieldOffset(Offset = "0x10")]
    private ExTypes ex_type;
    [Token(Token = "0x400717A")]
    [FieldOffset(Offset = "0x14")]
    private SkillParamCalcTypes calc_type;
    [Token(Token = "0x400717B")]
    [FieldOffset(Offset = "0x18")]
    private int value;
    [Token(Token = "0x400717C")]
    [FieldOffset(Offset = "0x1C")]
    private string tag;

    [Token(Token = "0x17000F85")]
    public string DrawName
    {
      [Token(Token = "0x60076E4"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F86")]
    public ParamTypes Type
    {
      [Token(Token = "0x60076E5"), Address(RVA = "0x39B080", Offset = "0x399E80", VA = "0x1039B080")] get
      {
        return new ParamTypes();
      }
    }

    [Token(Token = "0x17000F87")]
    public ExTypes ExType
    {
      [Token(Token = "0x60076E6"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new ExTypes();
      }
    }

    [Token(Token = "0x17000F88")]
    public SkillParamCalcTypes CalcType
    {
      [Token(Token = "0x60076E7"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new SkillParamCalcTypes();
      }
    }

    [Token(Token = "0x17000F89")]
    public int Value
    {
      [Token(Token = "0x60076E8"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F8A")]
    public string Tag
    {
      [Token(Token = "0x60076E9"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60076EA")]
    [Address(RVA = "0x39B030", Offset = "0x399E30", VA = "0x1039B030")]
    public void Deserialize(JSON_RunePrideBonusData json)
    {
    }

    [Token(Token = "0x60076EB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePrideBonusData()
    {
    }
  }
}
