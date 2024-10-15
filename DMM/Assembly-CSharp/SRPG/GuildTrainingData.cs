// Decompiled with JetBrains decompiler
// Type: SRPG.GuildTrainingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002533")]
  public class GuildTrainingData
  {
    [Token(Token = "0x170016C9")]
    public string ExpansionId
    {
      [Token(Token = "0x600A3BF"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600A3C0"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x170016CA")]
    public int SlotNo
    {
      [Token(Token = "0x600A3C1"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A3C2"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x170016CB")]
    public long UnitIid
    {
      [Token(Token = "0x600A3C3"), Address(RVA = "0x361230", Offset = "0x360030", VA = "0x10361230")] get
      {
        return new long();
      }
      [Token(Token = "0x600A3C4"), Address(RVA = "0x374A90", Offset = "0x373890", VA = "0x10374A90")] private set
      {
      }
    }

    [Token(Token = "0x170016CC")]
    public DateTime EndTime
    {
      [Token(Token = "0x600A3C5"), Address(RVA = "0x31CBF0", Offset = "0x31B9F0", VA = "0x1031CBF0")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600A3C6"), Address(RVA = "0x372E10", Offset = "0x371C10", VA = "0x10372E10")] private set
      {
      }
    }

    [Token(Token = "0x600A3C7")]
    [Address(RVA = "0x65DE50", Offset = "0x65CC50", VA = "0x1065DE50")]
    public void CreateDummy(string pageId, int slot_no)
    {
    }

    [Token(Token = "0x600A3C8")]
    [Address(RVA = "0x65DEE0", Offset = "0x65CCE0", VA = "0x1065DEE0")]
    public bool Deserialize(Json_GuildTrainingData json) => new bool();

    [Token(Token = "0x600A3C9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildTrainingData()
    {
    }
  }
}
