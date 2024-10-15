// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.AIPatrolTableFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007C8")]
  public sealed class AIPatrolTableFormatter : 
    IMessagePackFormatter<AIPatrolTable>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001420")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001421")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020A6")]
    [Address(RVA = "0xD00430", Offset = "0xCFF230", VA = "0x10D00430")]
    public AIPatrolTableFormatter()
    {
    }

    [Token(Token = "0x60020A7")]
    [Address(RVA = "0xD00250", Offset = "0xCFF050", VA = "0x10D00250", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      AIPatrolTable value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020A8")]
    [Address(RVA = "0xCFFF00", Offset = "0xCFED00", VA = "0x10CFFF00", Slot = "5")]
    public AIPatrolTable Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (AIPatrolTable) null;
    }
  }
}
