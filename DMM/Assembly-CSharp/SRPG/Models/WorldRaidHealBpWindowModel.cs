// Decompiled with JetBrains decompiler
// Type: SRPG.Models.WorldRaidHealBpWindowModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033E0")]
  public class WorldRaidHealBpWindowModel
  {
    [Token(Token = "0x400F5D1")]
    [FieldOffset(Offset = "0x3C")]
    private bool mNotEnoughBp;
    [Token(Token = "0x400F5D2")]
    [FieldOffset(Offset = "0x40")]
    private int mBpByCoin;
    [Token(Token = "0x400F5D3")]
    [FieldOffset(Offset = "0x44")]
    private int mMaxBp;
    [Token(Token = "0x400F5D4")]
    [FieldOffset(Offset = "0x48")]
    private WorldRaidManager mManager;
    [Token(Token = "0x400F5D5")]
    [FieldOffset(Offset = "0x4C")]
    private WorldRaidBpHealParam mHealParam;
    [Token(Token = "0x400F5D6")]
    [FieldOffset(Offset = "0x50")]
    private List<int> mNeedCoinList;

    [Token(Token = "0x17002158")]
    public int NowBp
    {
      [Token(Token = "0x600E88B"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600E88C"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x17002159")]
    public int NowCoin
    {
      [Token(Token = "0x600E88D"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x600E88E"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x1700215A")]
    public int SliderMin
    {
      [Token(Token = "0x600E88F"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
      [Token(Token = "0x600E890"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
      {
      }
    }

    [Token(Token = "0x1700215B")]
    public int SliderMax
    {
      [Token(Token = "0x600E891"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
      [Token(Token = "0x600E892"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
      {
      }
    }

    [Token(Token = "0x1700215C")]
    public int SelectCount
    {
      [Token(Token = "0x600E893"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
      [Token(Token = "0x600E894"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")] private set
      {
      }
    }

    [Token(Token = "0x1700215D")]
    public int NeedCoin
    {
      [Token(Token = "0x600E895"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600E896"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] private set
      {
      }
    }

    [Token(Token = "0x1700215E")]
    public string TopText
    {
      [Token(Token = "0x600E897"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E898"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] private set
      {
      }
    }

    [Token(Token = "0x1700215F")]
    public int HealStartNum
    {
      [Token(Token = "0x600E899"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
      [Token(Token = "0x600E89A"), Address(RVA = "0x311230", Offset = "0x310030", VA = "0x10311230")] private set
      {
      }
    }

    [Token(Token = "0x17002160")]
    public int HealEndNum
    {
      [Token(Token = "0x600E89B"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
      [Token(Token = "0x600E89C"), Address(RVA = "0x36F650", Offset = "0x36E450", VA = "0x1036F650")] private set
      {
      }
    }

    [Token(Token = "0x17002161")]
    public bool DownButtonEnable
    {
      [Token(Token = "0x600E89D"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E89E"), Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", VA = "0x104A9DB0")] private set
      {
      }
    }

    [Token(Token = "0x17002162")]
    public bool UpButtonEnable
    {
      [Token(Token = "0x600E89F"), Address(RVA = "0x34B870", Offset = "0x34A670", VA = "0x1034B870")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E8A0"), Address(RVA = "0x574130", Offset = "0x572F30", VA = "0x10574130")] private set
      {
      }
    }

    [Token(Token = "0x17002163")]
    public bool IsEnoughCost
    {
      [Token(Token = "0x600E8A1"), Address(RVA = "0x39CB50", Offset = "0x39B950", VA = "0x1039CB50")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E8A2"), Address(RVA = "0xAC7310", Offset = "0xAC6110", VA = "0x10AC7310")] private set
      {
      }
    }

    [Token(Token = "0x17002164")]
    public bool IsEqualityCost
    {
      [Token(Token = "0x600E8A3"), Address(RVA = "0xAB4EA0", Offset = "0xAB3CA0", VA = "0x10AB4EA0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E8A4"), Address(RVA = "0xAC7320", Offset = "0xAC6120", VA = "0x10AC7320")] private set
      {
      }
    }

    [Token(Token = "0x17002165")]
    public int OnceCost
    {
      [Token(Token = "0x600E8A5"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new int();
      }
      [Token(Token = "0x600E8A6"), Address(RVA = "0x373930", Offset = "0x372730", VA = "0x10373930")] private set
      {
      }
    }

    [Token(Token = "0x17002166")]
    public bool IsHealLimit
    {
      [Token(Token = "0x600E8A7"), Address(RVA = "0x54FFB0", Offset = "0x54EDB0", VA = "0x1054FFB0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E8A8"), Address(RVA = "0x54FC50", Offset = "0x54EA50", VA = "0x1054FC50")] private set
      {
      }
    }

    [Token(Token = "0x17002167")]
    public int RemainHealCount
    {
      [Token(Token = "0x600E8A9"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return new int();
      }
      [Token(Token = "0x600E8AA"), Address(RVA = "0x374A30", Offset = "0x373830", VA = "0x10374A30")] private set
      {
      }
    }

    [Token(Token = "0x600E8AB")]
    [Address(RVA = "0xAD5180", Offset = "0xAD3F80", VA = "0x10AD5180")]
    public void Initialize(bool _not_enough_bp)
    {
    }

    [Token(Token = "0x600E8AC")]
    [Address(RVA = "0xAD5550", Offset = "0xAD4350", VA = "0x10AD5550")]
    public void RefreshData()
    {
    }

    [Token(Token = "0x600E8AD")]
    [Address(RVA = "0xAD5630", Offset = "0xAD4430", VA = "0x10AD5630")]
    public void SetSliderEvent(int _select)
    {
    }

    [Token(Token = "0x600E8AE")]
    [Address(RVA = "0xAD56D0", Offset = "0xAD44D0", VA = "0x10AD56D0")]
    public void SliderUpCount()
    {
    }

    [Token(Token = "0x600E8AF")]
    [Address(RVA = "0xAD56B0", Offset = "0xAD44B0", VA = "0x10AD56B0")]
    public void SliderDownCount()
    {
    }

    [Token(Token = "0x600E8B0")]
    [Address(RVA = "0xAD5530", Offset = "0xAD4330", VA = "0x10AD5530")]
    public bool IsActiveNowBp(int _num) => new bool();

    [Token(Token = "0x600E8B1")]
    [Address(RVA = "0xAD5510", Offset = "0xAD4310", VA = "0x10AD5510")]
    public bool IsAcitveHealBp(int _num) => new bool();

    [Token(Token = "0x600E8B2")]
    [Address(RVA = "0xAD56F0", Offset = "0xAD44F0", VA = "0x10AD56F0")]
    public WorldRaidHealBpWindowModel()
    {
    }
  }
}
