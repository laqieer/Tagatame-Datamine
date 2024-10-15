// Decompiled with JetBrains decompiler
// Type: SRPG.VersusUnitCondParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EEC")]
  public class VersusUnitCondParam
  {
    [Token(Token = "0x4008216")]
    [FieldOffset(Offset = "0x8")]
    private string mId;
    [Token(Token = "0x4008217")]
    [FieldOffset(Offset = "0xC")]
    private UnitCondType mMode;
    [Token(Token = "0x4008218")]
    [FieldOffset(Offset = "0x10")]
    private List<VersusUnitCondData> mCondition;

    [Token(Token = "0x170011DF")]
    public string Id
    {
      [Token(Token = "0x6007E65"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170011E0")]
    public UnitCondType Mode
    {
      [Token(Token = "0x6007E66"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new UnitCondType();
      }
    }

    [Token(Token = "0x170011E1")]
    public List<VersusUnitCondData> Condition
    {
      [Token(Token = "0x6007E67"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<VersusUnitCondData>) null;
      }
    }

    [Token(Token = "0x6007E68")]
    [Address(RVA = "0x3FD620", Offset = "0x3FC420", VA = "0x103FD620")]
    public bool Deserialize(JSON_VersusUnitCondParam json) => new bool();

    [Token(Token = "0x6007E69")]
    [Address(RVA = "0x3FD750", Offset = "0x3FC550", VA = "0x103FD750")]
    public static void Deserialize(
      ref ParamDictionary<string, VersusUnitCondParam> ref_params,
      JSON_VersusUnitCondParam[] jsons)
    {
    }

    [Token(Token = "0x6007E6A")]
    [Address(RVA = "0x3FD9A0", Offset = "0x3FC7A0", VA = "0x103FD9A0")]
    public static VersusUnitCondParam GetVersusUnitCondParam(string id)
    {
      return (VersusUnitCondParam) null;
    }

    [Token(Token = "0x6007E6B")]
    [Address(RVA = "0x3FDAA0", Offset = "0x3FC8A0", VA = "0x103FDAA0")]
    public bool IsUnitCond(UnitData unit) => new bool();

    [Token(Token = "0x6007E6C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VersusUnitCondParam()
    {
    }
  }
}
