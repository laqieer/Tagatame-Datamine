// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BattleCore_Json_BtlDropFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007E8")]
  public sealed class BattleCore_Json_BtlDropFormatter : 
    IMessagePackFormatter<BattleCore.Json_BtlDrop>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001460")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001461")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002106")]
    [Address(RVA = "0xD295C0", Offset = "0xD283C0", VA = "0x10D295C0")]
    public BattleCore_Json_BtlDropFormatter()
    {
    }

    [Token(Token = "0x6002107")]
    [Address(RVA = "0xD29340", Offset = "0xD28140", VA = "0x10D29340", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BattleCore.Json_BtlDrop value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002108")]
    [Address(RVA = "0xD28F20", Offset = "0xD27D20", VA = "0x10D28F20", Slot = "5")]
    public BattleCore.Json_BtlDrop Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BattleCore.Json_BtlDrop) null;
    }
  }
}
