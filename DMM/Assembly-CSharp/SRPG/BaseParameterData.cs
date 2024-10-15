// Decompiled with JetBrains decompiler
// Type: SRPG.BaseParameterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E72")]
  public class BaseParameterData
  {
    [Token(Token = "0x4002C23")]
    [FieldOffset(Offset = "0x8")]
    private ParamTypes type;
    [Token(Token = "0x4002C24")]
    [FieldOffset(Offset = "0xC")]
    private string drawName;
    [Token(Token = "0x4002C25")]
    [FieldOffset(Offset = "0x10")]
    private int value;
    [Token(Token = "0x4002C26")]
    [FieldOffset(Offset = "0x14")]
    private SkillParamCalcTypes calcType;
    [Token(Token = "0x4002C27")]
    [FieldOffset(Offset = "0x18")]
    private ExTypes subType;
    [Token(Token = "0x4002C28")]
    [FieldOffset(Offset = "0x1C")]
    private string tag;

    [Token(Token = "0x17000479")]
    public ParamTypes Type
    {
      [Token(Token = "0x6003BD5"), Address(RVA = "0x357AF0", Offset = "0x3568F0", VA = "0x10357AF0")] get
      {
        return new ParamTypes();
      }
    }

    [Token(Token = "0x1700047A")]
    public string DrawName
    {
      [Token(Token = "0x6003BD6"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700047B")]
    public int Value
    {
      [Token(Token = "0x6003BD7"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700047C")]
    public SkillParamCalcTypes CalcType
    {
      [Token(Token = "0x6003BD8"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new SkillParamCalcTypes();
      }
    }

    [Token(Token = "0x1700047D")]
    public ExTypes SubType
    {
      [Token(Token = "0x6003BD9"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new ExTypes();
      }
    }

    [Token(Token = "0x1700047E")]
    public string Tag
    {
      [Token(Token = "0x6003BDA"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6003BDB")]
    [Address(RVA = "0x10E1FC0", Offset = "0x10E0DC0", VA = "0x110E1FC0")]
    public void SetParameter(
      ParamTypes type,
      SkillParamCalcTypes calcType,
      ExTypes subType,
      string drawName,
      int value,
      string tag)
    {
    }

    [Token(Token = "0x6003BDC")]
    [Address(RVA = "0x10E1F60", Offset = "0x10E0D60", VA = "0x110E1F60")]
    public void CopyTo(BaseParameterData _base)
    {
    }

    [Token(Token = "0x6003BDD")]
    [Address(RVA = "0x39B6E0", Offset = "0x39A4E0", VA = "0x1039B6E0")]
    public void AddValue(int value)
    {
    }

    [Token(Token = "0x6003BDE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BaseParameterData()
    {
    }
  }
}
