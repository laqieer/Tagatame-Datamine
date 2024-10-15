// Decompiled with JetBrains decompiler
// Type: SRPG.Json_BtlRewardConceptCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000DAD")]
  [MessagePackObject(true)]
  public class Json_BtlRewardConceptCard
  {
    [Token(Token = "0x4002787")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4002788")]
    [FieldOffset(Offset = "0xC")]
    public int num;
    [Token(Token = "0x4002789")]
    [FieldOffset(Offset = "0x10")]
    public string get_unit;
    [Token(Token = "0x400278A")]
    [FieldOffset(Offset = "0x18")]
    public long get_unit_iid;

    [Token(Token = "0x170003C6")]
    public bool IsGetUnit
    {
      [Token(Token = "0x6003761"), Address(RVA = "0x10A1C20", Offset = "0x10A0A20", VA = "0x110A1C20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003762")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_BtlRewardConceptCard()
    {
    }
  }
}
