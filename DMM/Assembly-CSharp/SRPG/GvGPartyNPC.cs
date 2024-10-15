// Decompiled with JetBrains decompiler
// Type: SRPG.GvGPartyNPC
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025BB")]
  public class GvGPartyNPC
  {
    [Token(Token = "0x17001782")]
    public long UniqueID
    {
      [Token(Token = "0x600A78A"), Address(RVA = "0x305C20", Offset = "0x304A20", VA = "0x10305C20")] get
      {
        return new long();
      }
      [Token(Token = "0x600A78B"), Address(RVA = "0x2E2BB0", Offset = "0x2E19B0", VA = "0x102E2BB0")] private set
      {
      }
    }

    [Token(Token = "0x17001783")]
    public int HP
    {
      [Token(Token = "0x600A78C"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A78D"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
      {
      }
    }

    [Token(Token = "0x600A78E")]
    [Address(RVA = "0x6C1B60", Offset = "0x6C0960", VA = "0x106C1B60")]
    public bool Deserialize(JSON_GvGPartyNPC json) => new bool();

    [Token(Token = "0x600A78F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GvGPartyNPC()
    {
    }
  }
}
