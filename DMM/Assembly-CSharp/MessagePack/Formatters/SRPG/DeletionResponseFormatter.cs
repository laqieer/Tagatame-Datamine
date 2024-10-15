// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.DeletionResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B3A")]
  public sealed class DeletionResponseFormatter : 
    IMessagePackFormatter<DeletionResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001B04")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001B05")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002AFC")]
    [Address(RVA = "0xF5BC30", Offset = "0xF5AA30", VA = "0x10F5BC30")]
    public DeletionResponseFormatter()
    {
    }

    [Token(Token = "0x6002AFD")]
    [Address(RVA = "0xF5B940", Offset = "0xF5A740", VA = "0x10F5B940", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      DeletionResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002AFE")]
    [Address(RVA = "0xF5B510", Offset = "0xF5A310", VA = "0x10F5B510", Slot = "5")]
    public DeletionResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (DeletionResponse) null;
    }
  }
}
