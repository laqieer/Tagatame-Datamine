// Decompiled with JetBrains decompiler
// Type: SRPG.WeatherDetailParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EF3")]
  public class WeatherDetailParam
  {
    [Token(Token = "0x400824A")]
    [FieldOffset(Offset = "0x8")]
    private List<string> mBuffIdLists;
    [Token(Token = "0x400824B")]
    [FieldOffset(Offset = "0xC")]
    private List<string> mCondIdLists;
    [Token(Token = "0x400824C")]
    [FieldOffset(Offset = "0x10")]
    private bool mIsForceHit;
    [Token(Token = "0x400824D")]
    [FieldOffset(Offset = "0x11")]
    private bool mIsForceHitDelete;
    [Token(Token = "0x400824E")]
    [FieldOffset(Offset = "0x14")]
    private EWeatherTarget mTarget;
    [Token(Token = "0x400824F")]
    [FieldOffset(Offset = "0x18")]
    private List<SRPG.AttackTypes> mAttackTypes;
    [Token(Token = "0x4008250")]
    [FieldOffset(Offset = "0x1C")]
    private List<SRPG.AttackDetailTypes> mAttackDetailTypes;
    [Token(Token = "0x4008251")]
    [FieldOffset(Offset = "0x20")]
    private List<EElement> mAttackElements;
    [Token(Token = "0x4008252")]
    [FieldOffset(Offset = "0x24")]
    private List<string> mCustomTargets;

    [Token(Token = "0x170011EB")]
    public List<string> BuffIdLists
    {
      [Token(Token = "0x6007E7D"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x170011EC")]
    public List<string> CondIdLists
    {
      [Token(Token = "0x6007E7E"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x170011ED")]
    public bool IsForceHit
    {
      [Token(Token = "0x6007E7F"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170011EE")]
    public bool IsForceHitDelete
    {
      [Token(Token = "0x6007E80"), Address(RVA = "0x3E6E30", Offset = "0x3E5C30", VA = "0x103E6E30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170011EF")]
    public EWeatherTarget Target
    {
      [Token(Token = "0x6007E81"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new EWeatherTarget();
      }
    }

    [Token(Token = "0x170011F0")]
    public List<SRPG.AttackTypes> AttackTypes
    {
      [Token(Token = "0x6007E82"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<SRPG.AttackTypes>) null;
      }
    }

    [Token(Token = "0x170011F1")]
    public List<SRPG.AttackDetailTypes> AttackDetailTypes
    {
      [Token(Token = "0x6007E83"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (List<SRPG.AttackDetailTypes>) null;
      }
    }

    [Token(Token = "0x170011F2")]
    public List<EElement> AttackElements
    {
      [Token(Token = "0x6007E84"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (List<EElement>) null;
      }
    }

    [Token(Token = "0x170011F3")]
    public List<string> CustomTargets
    {
      [Token(Token = "0x6007E85"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x6007E86")]
    [Address(RVA = "0x3FE080", Offset = "0x3FCE80", VA = "0x103FE080")]
    public bool IsAttackTypeNone() => new bool();

    [Token(Token = "0x6007E87")]
    [Address(RVA = "0x3FE040", Offset = "0x3FCE40", VA = "0x103FE040")]
    public bool IsAttackDetailTypesNone() => new bool();

    [Token(Token = "0x6007E88")]
    [Address(RVA = "0x3FE0C0", Offset = "0x3FCEC0", VA = "0x103FE0C0")]
    public bool IsElementsNone() => new bool();

    [Token(Token = "0x6007E89")]
    [Address(RVA = "0x3FDC10", Offset = "0x3FCA10", VA = "0x103FDC10")]
    public bool Deserialize(JSON_WeatherDetailParam json) => new bool();

    [Token(Token = "0x6007E8A")]
    [Address(RVA = "0x3FE100", Offset = "0x3FCF00", VA = "0x103FE100")]
    public WeatherDetailParam()
    {
    }
  }
}
