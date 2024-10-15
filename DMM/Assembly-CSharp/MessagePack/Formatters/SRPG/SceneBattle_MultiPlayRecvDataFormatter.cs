// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.SceneBattle_MultiPlayRecvDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008CB")]
  public sealed class SceneBattle_MultiPlayRecvDataFormatter : 
    IMessagePackFormatter<SceneBattle.MultiPlayRecvData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001626")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001627")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023AF")]
    [Address(RVA = "0xDDBF70", Offset = "0xDDAD70", VA = "0x10DDBF70")]
    public SceneBattle_MultiPlayRecvDataFormatter()
    {
    }

    [Token(Token = "0x60023B0")]
    [Address(RVA = "0xDDB8B0", Offset = "0xDDA6B0", VA = "0x10DDB8B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SceneBattle.MultiPlayRecvData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023B1")]
    [Address(RVA = "0xDDB0B0", Offset = "0xDD9EB0", VA = "0x10DDB0B0", Slot = "5")]
    public SceneBattle.MultiPlayRecvData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (SceneBattle.MultiPlayRecvData) null;
    }
  }
}
