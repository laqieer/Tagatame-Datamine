// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidBossData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D5B")]
  public class WorldRaidBossData
  {
    [Token(Token = "0x17001BA4")]
    public string BossIname
    {
      [Token(Token = "0x600D340"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600D341"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17001BA5")]
    public long CurrentHP
    {
      [Token(Token = "0x600D342"), Address(RVA = "0x361230", Offset = "0x360030", VA = "0x10361230")] get
      {
        return new long();
      }
      [Token(Token = "0x600D343"), Address(RVA = "0x374A90", Offset = "0x373890", VA = "0x10374A90")] private set
      {
      }
    }

    [Token(Token = "0x17001BA6")]
    public int Lap
    {
      [Token(Token = "0x600D344"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
      [Token(Token = "0x600D345"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")] protected set
      {
      }
    }

    [Token(Token = "0x600D346")]
    [Address(RVA = "0x9E1F90", Offset = "0x9E0D90", VA = "0x109E1F90")]
    public long CalcMaxHP() => new long();

    [Token(Token = "0x600D347")]
    [Address(RVA = "0x9E2040", Offset = "0x9E0E40", VA = "0x109E2040")]
    public bool Deserialize(JSON_WorldRaidBossData json) => new bool();

    [Token(Token = "0x600D348")]
    [Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")]
    public void SetLap(int _lap)
    {
    }

    [Token(Token = "0x600D349")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public WorldRaidBossData()
    {
    }
  }
}
