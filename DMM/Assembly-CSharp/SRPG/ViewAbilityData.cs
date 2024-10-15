// Decompiled with JetBrains decompiler
// Type: SRPG.ViewAbilityData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FFA")]
  public class ViewAbilityData
  {
    [Token(Token = "0x400883C")]
    [FieldOffset(Offset = "0x8")]
    private AbilityParam base_ability;
    [Token(Token = "0x400883D")]
    [FieldOffset(Offset = "0xC")]
    private AbilityDeriveParam ability_derive_param;
    [Token(Token = "0x400883E")]
    [FieldOffset(Offset = "0x10")]
    private bool is_enable_base_ability;
    [Token(Token = "0x400883F")]
    [FieldOffset(Offset = "0x11")]
    private bool is_locked_base_ability;
    [Token(Token = "0x4008840")]
    [FieldOffset(Offset = "0x14")]
    private List<ViewDeriveAbilityData> derive_abilities;

    [Token(Token = "0x170012E5")]
    public AbilityParam baseAbility
    {
      [Token(Token = "0x6008416"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (AbilityParam) null;
      }
    }

    [Token(Token = "0x170012E6")]
    public AbilityDeriveParam abilityDeriveParam
    {
      [Token(Token = "0x6008417"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (AbilityDeriveParam) null;
      }
    }

    [Token(Token = "0x170012E7")]
    public bool isEnableBaseAbility
    {
      [Token(Token = "0x6008418"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170012E8")]
    public bool isLockedBaseAbility
    {
      [Token(Token = "0x6008419"), Address(RVA = "0x3E6E30", Offset = "0x3E5C30", VA = "0x103E6E30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170012E9")]
    public List<ViewDeriveAbilityData> deriveAbilities
    {
      [Token(Token = "0x600841A"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<ViewDeriveAbilityData>) null;
      }
    }

    [Token(Token = "0x600841B")]
    [Address(RVA = "0x45AAA0", Offset = "0x4598A0", VA = "0x1045AAA0")]
    public void AddAbility(AbilityParam ability_param, bool is_enable, bool is_locked)
    {
    }

    [Token(Token = "0x600841C")]
    [Address(RVA = "0x45AAD0", Offset = "0x4598D0", VA = "0x1045AAD0")]
    public void AddAbility(
      string base_ability_iname,
      AbilityDeriveParam derive_param,
      string derive_ability_iname,
      bool is_enable)
    {
    }

    [Token(Token = "0x600841D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ViewAbilityData()
    {
    }
  }
}
