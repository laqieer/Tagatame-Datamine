// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ParamTypesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000563")]
  public sealed class ParamTypesFormatter : IMessagePackFormatter<ParamTypes>, IMessagePackFormatter
  {
    [Token(Token = "0x6001977")]
    [Address(RVA = "0x6A8150", Offset = "0x6A6F50", VA = "0x106A8150", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ParamTypes value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001978")]
    [Address(RVA = "0x6A8100", Offset = "0x6A6F00", VA = "0x106A8100", Slot = "5")]
    public ParamTypes Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ParamTypes();
    }

    [Token(Token = "0x6001979")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ParamTypesFormatter()
    {
    }
  }
}
