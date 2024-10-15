// Decompiled with JetBrains decompiler
// Type: SRPG.Models.BaseParameterModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033A9")]
  public class BaseParameterModel
  {
    [Token(Token = "0x400F469")]
    [FieldOffset(Offset = "0x8")]
    protected ParamTypes type;
    [Token(Token = "0x400F46A")]
    [FieldOffset(Offset = "0xA")]
    protected SkillParamCalcTypes calcType;
    [Token(Token = "0x400F46B")]
    [FieldOffset(Offset = "0xC")]
    protected ExTypes subType;
    [Token(Token = "0x400F46C")]
    [FieldOffset(Offset = "0x10")]
    protected string paramText;
    [Token(Token = "0x400F46D")]
    [FieldOffset(Offset = "0x14")]
    protected string paramName;
    [Token(Token = "0x400F46E")]
    [FieldOffset(Offset = "0x18")]
    protected int value;
    [Token(Token = "0x400F46F")]
    [FieldOffset(Offset = "0x1C")]
    protected string tag;
    [Token(Token = "0x400F470")]
    [FieldOffset(Offset = "0x20")]
    protected Action refreshCallback;

    [Token(Token = "0x17002039")]
    public ParamTypes Type
    {
      [Token(Token = "0x600E684"), Address(RVA = "0x357AF0", Offset = "0x3568F0", VA = "0x10357AF0")] get
      {
        return new ParamTypes();
      }
    }

    [Token(Token = "0x1700203A")]
    public string ParamText
    {
      [Token(Token = "0x600E685"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700203B")]
    public string ParamName
    {
      [Token(Token = "0x600E686"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700203C")]
    public int Value
    {
      [Token(Token = "0x600E687"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700203D")]
    public SkillParamCalcTypes CalcType
    {
      [Token(Token = "0x600E688"), Address(RVA = "0x34B070", Offset = "0x349E70", VA = "0x1034B070")] get
      {
        return new SkillParamCalcTypes();
      }
    }

    [Token(Token = "0x1700203E")]
    public ExTypes SubType
    {
      [Token(Token = "0x600E689"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new ExTypes();
      }
    }

    [Token(Token = "0x1700203F")]
    public string Tag
    {
      [Token(Token = "0x600E68A"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E68B")]
    [Address(RVA = "0xAC50E0", Offset = "0xAC3EE0", VA = "0x10AC50E0", Slot = "4")]
    public virtual void Initialize(BaseParameterData data)
    {
    }

    [Token(Token = "0x600E68C")]
    [Address(RVA = "0xAC5130", Offset = "0xAC3F30", VA = "0x10AC5130")]
    private void SetText()
    {
    }

    [Token(Token = "0x600E68D")]
    [Address(RVA = "0xAC50C0", Offset = "0xAC3EC0", VA = "0x10AC50C0")]
    public void ChangeValue(int _value)
    {
    }

    [Token(Token = "0x600E68E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BaseParameterModel()
    {
    }
  }
}
