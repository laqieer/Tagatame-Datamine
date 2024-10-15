// Decompiled with JetBrains decompiler
// Type: SRPG.TobiraConditionParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D5B")]
  public class TobiraConditionParam
  {
    [Token(Token = "0x4007392")]
    [FieldOffset(Offset = "0x8")]
    private TobiraConditionParam.ConditionType mCondType;
    [Token(Token = "0x4007393")]
    [FieldOffset(Offset = "0xC")]
    private string mCondIname;
    [Token(Token = "0x4007394")]
    [FieldOffset(Offset = "0x10")]
    private TobiraCondsUnitParam mCondUnit;

    [Token(Token = "0x17000FFB")]
    public TobiraConditionParam.ConditionType CondType
    {
      [Token(Token = "0x6007834"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new TobiraConditionParam.ConditionType();
      }
    }

    [Token(Token = "0x17000FFC")]
    public string CondIname
    {
      [Token(Token = "0x6007835"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FFD")]
    public TobiraCondsUnitParam CondUnit
    {
      [Token(Token = "0x6007836"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (TobiraCondsUnitParam) null;
      }
    }

    [Token(Token = "0x6007837")]
    [Address(RVA = "0x31B680", Offset = "0x31A480", VA = "0x1031B680")]
    public void Deserialize(JSON_TobiraConditionParam json)
    {
    }

    [Token(Token = "0x6007838")]
    [Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")]
    public void SetCondUnit(TobiraCondsUnitParam cond_unit)
    {
    }

    [Token(Token = "0x6007839")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TobiraConditionParam()
    {
    }

    [Token(Token = "0x2001D5C")]
    public enum ConditionType
    {
      [Token(Token = "0x4007396")] None,
      [Token(Token = "0x4007397")] Unit,
      [Token(Token = "0x4007398")] Quest,
    }
  }
}
