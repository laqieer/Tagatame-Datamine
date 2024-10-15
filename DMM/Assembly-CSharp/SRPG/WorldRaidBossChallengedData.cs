// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidBossChallengedData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D5C")]
  public class WorldRaidBossChallengedData : WorldRaidBossData
  {
    [Token(Token = "0x17001BA7")]
    public bool Challenged
    {
      [Token(Token = "0x600D34A"), Address(RVA = "0x305F30", Offset = "0x304D30", VA = "0x10305F30")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D34B"), Address(RVA = "0x305F50", Offset = "0x304D50", VA = "0x10305F50")] private set
      {
      }
    }

    [Token(Token = "0x600D34C")]
    [Address(RVA = "0x9E1F40", Offset = "0x9E0D40", VA = "0x109E1F40")]
    public bool Deserialize(JSON_WorldRaidBossChallengedData json) => new bool();

    [Token(Token = "0x600D34D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public WorldRaidBossChallengedData()
    {
    }
  }
}
