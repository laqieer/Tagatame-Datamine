// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidLogData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D61")]
  public class WorldRaidLogData
  {
    [Token(Token = "0x17001BB5")]
    public int LogId
    {
      [Token(Token = "0x600D371"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600D372"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x17001BB6")]
    public string BossIname
    {
      [Token(Token = "0x600D373"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600D374"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17001BB7")]
    public string PlayerName
    {
      [Token(Token = "0x600D375"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600D376"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17001BB8")]
    public long Damage
    {
      [Token(Token = "0x600D377"), Address(RVA = "0x34F480", Offset = "0x34E280", VA = "0x1034F480")] get
      {
        return new long();
      }
      [Token(Token = "0x600D378"), Address(RVA = "0x372E10", Offset = "0x371C10", VA = "0x10372E10")] private set
      {
      }
    }

    [Token(Token = "0x600D379")]
    [Address(RVA = "0x9E6590", Offset = "0x9E5390", VA = "0x109E6590")]
    public bool Deserialize(JSON_WorldRaidLogData json) => new bool();

    [Token(Token = "0x600D37A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public WorldRaidLogData()
    {
    }
  }
}
