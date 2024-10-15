// Decompiled with JetBrains decompiler
// Type: SRPG.GuildTrainingEnergy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002534")]
  public class GuildTrainingEnergy
  {
    [Token(Token = "0x170016CD")]
    public DateTime BaseTime
    {
      [Token(Token = "0x600A3CA"), Address(RVA = "0x2ECBB0", Offset = "0x2EB9B0", VA = "0x102ECBB0")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600A3CB"), Address(RVA = "0x2E2BB0", Offset = "0x2E19B0", VA = "0x102E2BB0")] private set
      {
      }
    }

    [Token(Token = "0x170016CE")]
    public int EnergyNum
    {
      [Token(Token = "0x600A3CC"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A3CD"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
      {
      }
    }

    [Token(Token = "0x170016CF")]
    public int EnergyLimit
    {
      [Token(Token = "0x600A3CE"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
      [Token(Token = "0x600A3CF"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
      {
      }
    }

    [Token(Token = "0x600A3D0")]
    [Address(RVA = "0x6613A0", Offset = "0x6601A0", VA = "0x106613A0")]
    public bool Deserialize(Json_GuildTrainingEnergy json) => new bool();

    [Token(Token = "0x600A3D1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildTrainingEnergy()
    {
    }
  }
}
