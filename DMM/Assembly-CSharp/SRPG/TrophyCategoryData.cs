// Decompiled with JetBrains decompiler
// Type: SRPG.TrophyCategoryData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B89")]
  public class TrophyCategoryData
  {
    [Token(Token = "0x400D5A7")]
    [FieldOffset(Offset = "0x8")]
    private TrophyCategoryParam category_param;
    [Token(Token = "0x400D5A8")]
    [FieldOffset(Offset = "0xC")]
    private List<TrophyState> trophies;
    [Token(Token = "0x400D5A9")]
    [FieldOffset(Offset = "0x10")]
    private List<TrophyState> tmp1_trophies;
    [Token(Token = "0x400D5AA")]
    [FieldOffset(Offset = "0x14")]
    private List<TrophyState> tmp2_trophies;
    [Token(Token = "0x400D5AB")]
    [FieldOffset(Offset = "0x18")]
    private bool is_in_completed_data;

    [Token(Token = "0x17001A82")]
    public TrophyCategoryParam Param
    {
      [Token(Token = "0x600C7DC"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (TrophyCategoryParam) null;
      }
    }

    [Token(Token = "0x17001A83")]
    public List<TrophyState> Trophies
    {
      [Token(Token = "0x600C7DD"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<TrophyState>) null;
      }
    }

    [Token(Token = "0x17001A84")]
    public bool IsInCompletedData
    {
      [Token(Token = "0x600C7DE"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C7DF")]
    [Address(RVA = "0x90C920", Offset = "0x90B720", VA = "0x1090C920")]
    public TrophyCategoryData(TrophyCategoryParam _tcp)
    {
    }

    [Token(Token = "0x600C7E0")]
    [Address(RVA = "0x90C690", Offset = "0x90B490", VA = "0x1090C690")]
    public void AddTrophy(TrophyState _trophy)
    {
    }

    [Token(Token = "0x600C7E1")]
    [Address(RVA = "0x90C840", Offset = "0x90B640", VA = "0x1090C840")]
    public void RemoveTrophy(TrophyState _trophy)
    {
    }

    [Token(Token = "0x600C7E2")]
    [Address(RVA = "0x90C730", Offset = "0x90B530", VA = "0x1090C730")]
    public void Apply()
    {
    }
  }
}
