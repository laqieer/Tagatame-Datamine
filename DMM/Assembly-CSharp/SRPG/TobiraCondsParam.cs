// Decompiled with JetBrains decompiler
// Type: SRPG.TobiraCondsParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D5D")]
  public class TobiraCondsParam
  {
    [Token(Token = "0x4007399")]
    [FieldOffset(Offset = "0x8")]
    private string mUnitIname;
    [Token(Token = "0x400739A")]
    [FieldOffset(Offset = "0xC")]
    private TobiraParam.Category mCategory;
    [Token(Token = "0x400739B")]
    [FieldOffset(Offset = "0x10")]
    private List<TobiraConditionParam> mConditions;

    [Token(Token = "0x17000FFE")]
    public string UnitIname
    {
      [Token(Token = "0x600783A"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FFF")]
    public TobiraParam.Category TobiraCategory
    {
      [Token(Token = "0x600783B"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new TobiraParam.Category();
      }
    }

    [Token(Token = "0x17001000")]
    public TobiraConditionParam[] Conditions
    {
      [Token(Token = "0x600783C"), Address(RVA = "0x3A3DC0", Offset = "0x3A2BC0", VA = "0x103A3DC0")] get
      {
        return (TobiraConditionParam[]) null;
      }
    }

    [Token(Token = "0x600783D")]
    [Address(RVA = "0x3A3C20", Offset = "0x3A2A20", VA = "0x103A3C20")]
    public void Deserialize(JSON_TobiraCondsParam json)
    {
    }

    [Token(Token = "0x600783E")]
    [Address(RVA = "0x3A3D50", Offset = "0x3A2B50", VA = "0x103A3D50")]
    public TobiraCondsParam()
    {
    }
  }
}
