// Decompiled with JetBrains decompiler
// Type: SRPG.Models.WorldRaidBattlePointModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033DE")]
  public class WorldRaidBattlePointModel
  {
    [Token(Token = "0x400F5B8")]
    [FieldOffset(Offset = "0x18")]
    private WorldRaidParam mParam;
    [Token(Token = "0x400F5B9")]
    [FieldOffset(Offset = "0x1C")]
    private WorldRaidBpHealParam mHealParam;
    [Token(Token = "0x400F5BA")]
    [FieldOffset(Offset = "0x20")]
    private bool mIsUpdate;
    [Token(Token = "0x400F5BB")]
    [FieldOffset(Offset = "0x21")]
    private bool mIsRemainTimeUpdate;

    [Token(Token = "0x1700214F")]
    public bool IsActive
    {
      [Token(Token = "0x600E871"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E872"), Address(RVA = "0x3011A0", Offset = "0x2FFFA0", VA = "0x103011A0")] private set
      {
      }
    }

    [Token(Token = "0x17002150")]
    public int NowBp
    {
      [Token(Token = "0x600E873"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x600E874"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x17002151")]
    public string RemainTimeText
    {
      [Token(Token = "0x600E875"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E876"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17002152")]
    public bool IsDispRemainTime
    {
      [Token(Token = "0x600E877"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E878"), Address(RVA = "0x357B00", Offset = "0x356900", VA = "0x10357B00")] private set
      {
      }
    }

    [Token(Token = "0x17002153")]
    public bool IsNotTimeHeal
    {
      [Token(Token = "0x600E879"), Address(RVA = "0x39C2B0", Offset = "0x39B0B0", VA = "0x1039C2B0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E87A"), Address(RVA = "0x7B1CA0", Offset = "0x7B0AA0", VA = "0x107B1CA0")] private set
      {
      }
    }

    [Token(Token = "0x600E87B")]
    [Address(RVA = "0xAD4F60", Offset = "0xAD3D60", VA = "0x10AD4F60")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600E87C")]
    [Address(RVA = "0xAD50D0", Offset = "0xAD3ED0", VA = "0x10AD50D0")]
    public void RefreshData()
    {
    }

    [Token(Token = "0x600E87D")]
    [Address(RVA = "0xAD5060", Offset = "0xAD3E60", VA = "0x10AD5060")]
    public bool IsActiveNowBp(int _num) => new bool();

    [Token(Token = "0x600E87E")]
    [Address(RVA = "0xAD50A0", Offset = "0xAD3EA0", VA = "0x10AD50A0")]
    public bool IsInteractiveHealButton() => new bool();

    [Token(Token = "0x600E87F")]
    [Address(RVA = "0xAD5080", Offset = "0xAD3E80", VA = "0x10AD5080")]
    public bool IsBpHeal() => new bool();

    [Token(Token = "0x600E880")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public WorldRaidBattlePointModel()
    {
    }
  }
}
