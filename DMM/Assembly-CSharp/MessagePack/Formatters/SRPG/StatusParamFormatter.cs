// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.StatusParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000765")]
  public sealed class StatusParamFormatter : 
    IMessagePackFormatter<StatusParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001362")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001363")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F7D")]
    [Address(RVA = "0xCB89B0", Offset = "0xCB77B0", VA = "0x10CB89B0")]
    public StatusParamFormatter()
    {
    }

    [Token(Token = "0x6001F7E")]
    [Address(RVA = "0xCB8420", Offset = "0xCB7220", VA = "0x10CB8420", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      StatusParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F7F")]
    [Address(RVA = "0xCB7D50", Offset = "0xCB6B50", VA = "0x10CB7D50", Slot = "5")]
    public StatusParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (StatusParam) null;
    }
  }
}
