// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidBattleRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D60")]
  public class WorldRaidBattleRewardData
  {
    [Token(Token = "0x17001BB2")]
    public RaidRewardType Type
    {
      [Token(Token = "0x600D368"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new RaidRewardType();
      }
      [Token(Token = "0x600D369"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x17001BB3")]
    public string Iname
    {
      [Token(Token = "0x600D36A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600D36B"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17001BB4")]
    public int Num
    {
      [Token(Token = "0x600D36C"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
      [Token(Token = "0x600D36D"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
      {
      }
    }

    [Token(Token = "0x600D36E")]
    [Address(RVA = "0x9E1F00", Offset = "0x9E0D00", VA = "0x109E1F00")]
    public bool Deserialize(JSON_WorldRaidBattleRewardData json) => new bool();

    [Token(Token = "0x600D36F")]
    [Address(RVA = "0x9E1E10", Offset = "0x9E0C10", VA = "0x109E1E10")]
    public Json_Gift ConvertToJsonGift() => (Json_Gift) null;

    [Token(Token = "0x600D370")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public WorldRaidBattleRewardData()
    {
    }
  }
}
