// Decompiled with JetBrains decompiler
// Type: SRPG.GvGPartyUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025BA")]
  public class GvGPartyUnit : UnitData
  {
    [Token(Token = "0x17001781")]
    public int HP
    {
      [Token(Token = "0x600A785"), Address(RVA = "0x6C1C40", Offset = "0x6C0A40", VA = "0x106C1C40")] get
      {
        return new int();
      }
      [Token(Token = "0x600A786"), Address(RVA = "0x6C1BD0", Offset = "0x6C09D0", VA = "0x106C1BD0")] private set
      {
      }
    }

    [Token(Token = "0x600A787")]
    [Address(RVA = "0x6C1B90", Offset = "0x6C0990", VA = "0x106C1B90")]
    public bool Deserialize(JSON_GvGPartyUnit json) => new bool();

    [Token(Token = "0x600A788")]
    [Address(RVA = "0x6C1BD0", Offset = "0x6C09D0", VA = "0x106C1BD0")]
    public void SetHP(int hp)
    {
    }

    [Token(Token = "0x600A789")]
    [Address(RVA = "0x6C1BF0", Offset = "0x6C09F0", VA = "0x106C1BF0")]
    public GvGPartyUnit()
    {
    }
  }
}
