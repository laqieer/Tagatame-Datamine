// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidBpHealParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EFE")]
  public class WorldRaidBpHealParam
  {
    [Token(Token = "0x4008282")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4008283")]
    [FieldOffset(Offset = "0xC")]
    private List<WorldRaidBpHealParam.HealInfo> mHealInfos;

    [Token(Token = "0x17001209")]
    public string Iname
    {
      [Token(Token = "0x6007EB3"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700120A")]
    public List<WorldRaidBpHealParam.HealInfo> HealInfos
    {
      [Token(Token = "0x6007EB4"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<WorldRaidBpHealParam.HealInfo>) null;
      }
    }

    [Token(Token = "0x6007EB5")]
    [Address(RVA = "0x4131E0", Offset = "0x411FE0", VA = "0x104131E0")]
    public void Deserialize(JSON_WorldRaidBpHealParam _json)
    {
    }

    [Token(Token = "0x6007EB6")]
    [Address(RVA = "0x413340", Offset = "0x412140", VA = "0x10413340")]
    public static void Deserialize(
      ref List<WorldRaidBpHealParam> _list,
      JSON_WorldRaidBpHealParam[] _json)
    {
    }

    [Token(Token = "0x6007EB7")]
    [Address(RVA = "0x413790", Offset = "0x412590", VA = "0x10413790")]
    public static WorldRaidBpHealParam GetParam(string _iname) => (WorldRaidBpHealParam) null;

    [Token(Token = "0x6007EB8")]
    [Address(RVA = "0x413630", Offset = "0x412430", VA = "0x10413630")]
    public int GetNeedCoinByCount(int _count) => new int();

    [Token(Token = "0x6007EB9")]
    [Address(RVA = "0x413A30", Offset = "0x412830", VA = "0x10413A30")]
    public bool IsPossibleHeal(int _count) => new bool();

    [Token(Token = "0x6007EBA")]
    [Address(RVA = "0x4135D0", Offset = "0x4123D0", VA = "0x104135D0")]
    public int GetLimitHealCount() => new int();

    [Token(Token = "0x6007EBB")]
    [Address(RVA = "0x4138D0", Offset = "0x4126D0", VA = "0x104138D0")]
    public bool IsEqualityCost() => new bool();

    [Token(Token = "0x6007EBC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public WorldRaidBpHealParam()
    {
    }

    [Token(Token = "0x2001EFF")]
    public class HealInfo
    {
      [Token(Token = "0x1700120B")]
      public int MinCount
      {
        [Token(Token = "0x6007EBD"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return new int();
        }
        [Token(Token = "0x6007EBE"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
        {
        }
      }

      [Token(Token = "0x1700120C")]
      public int MaxCount
      {
        [Token(Token = "0x6007EBF"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new int();
        }
        [Token(Token = "0x6007EC0"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
        {
        }
      }

      [Token(Token = "0x1700120D")]
      public int NeedCoin
      {
        [Token(Token = "0x6007EC1"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return new int();
        }
        [Token(Token = "0x6007EC2"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
        {
        }
      }

      [Token(Token = "0x6007EC3")]
      [Address(RVA = "0x411370", Offset = "0x410170", VA = "0x10411370")]
      public void Deserialize(JSON_WorldRaidBpHealParam.HealInfo _json)
      {
      }

      [Token(Token = "0x6007EC4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public HealInfo()
      {
      }
    }
  }
}
