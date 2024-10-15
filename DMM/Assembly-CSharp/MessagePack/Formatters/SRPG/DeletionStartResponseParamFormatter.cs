// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.DeletionStartResponseParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B37")]
  public sealed class DeletionStartResponseParamFormatter : 
    IMessagePackFormatter<DeletionStartResponseParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AFE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AFF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002AF3")]
    [Address(RVA = "0xF5D270", Offset = "0xF5C070", VA = "0x10F5D270")]
    public DeletionStartResponseParamFormatter()
    {
    }

    [Token(Token = "0x6002AF4")]
    [Address(RVA = "0xF5D170", Offset = "0xF5BF70", VA = "0x10F5D170", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      DeletionStartResponseParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002AF5")]
    [Address(RVA = "0xF5CEA0", Offset = "0xF5BCA0", VA = "0x10F5CEA0", Slot = "5")]
    public DeletionStartResponseParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (DeletionStartResponseParam) null;
    }
  }
}
