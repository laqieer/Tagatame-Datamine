// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidTrainingPeriod
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FBE")]
  public class GuildRaidTrainingPeriod
  {
    [Token(Token = "0x170005D4")]
    public int PeriodId
    {
      [Token(Token = "0x6004172"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x6004173"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x170005D5")]
    public string Title
    {
      [Token(Token = "0x6004174"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6004175"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x170005D6")]
    public bool Selected
    {
      [Token(Token = "0x6004176"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
      [Token(Token = "0x6004177"), Address(RVA = "0x2C73C0", Offset = "0x2C61C0", VA = "0x102C73C0")] private set
      {
      }
    }

    [Token(Token = "0x6004178")]
    [Address(RVA = "0x11933F0", Offset = "0x11921F0", VA = "0x111933F0")]
    public bool Deserialize(JSON_GuildRaidTrainingPeriod json) => new bool();

    [Token(Token = "0x6004179")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildRaidTrainingPeriod()
    {
    }
  }
}
