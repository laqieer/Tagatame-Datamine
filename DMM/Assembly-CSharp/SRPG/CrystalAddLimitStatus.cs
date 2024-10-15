// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalAddLimitStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A83")]
  [MessagePackObject(true)]
  [Serializable]
  public class CrystalAddLimitStatus
  {
    [Token(Token = "0x17000BF5")]
    public ParamTypes Type
    {
      [Token(Token = "0x6006CE4"), Address(RVA = "0x357AF0", Offset = "0x3568F0", VA = "0x10357AF0")] get
      {
        return new ParamTypes();
      }
      [Token(Token = "0x6006CE5"), Address(RVA = "0x357B10", Offset = "0x356910", VA = "0x10357B10")] private set
      {
      }
    }

    [Token(Token = "0x17000BF6")]
    public int Value
    {
      [Token(Token = "0x6006CE6"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x6006CE7"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x17000BF7")]
    public string TagName
    {
      [Token(Token = "0x6006CE8"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006CE9"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17000BF8")]
    public SkillParamCalcTypes Calc
    {
      [Token(Token = "0x6006CEA"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new SkillParamCalcTypes();
      }
      [Token(Token = "0x6006CEB"), Address(RVA = "0x357B00", Offset = "0x356900", VA = "0x10357B00")] private set
      {
      }
    }

    [Token(Token = "0x6006CEC")]
    [Address(RVA = "0x357AB0", Offset = "0x3568B0", VA = "0x10357AB0")]
    public bool Deserialize(JSON_CrystalAddLimitStatus json) => new bool();

    [Token(Token = "0x6006CED")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalAddLimitStatus()
    {
    }
  }
}
