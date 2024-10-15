// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ExTypesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000571")]
  public sealed class ExTypesFormatter : IMessagePackFormatter<ExTypes>, IMessagePackFormatter
  {
    [Token(Token = "0x60019A1")]
    [Address(RVA = "0x69C4E0", Offset = "0x69B2E0", VA = "0x1069C4E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ExTypes value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019A2")]
    [Address(RVA = "0x69C490", Offset = "0x69B290", VA = "0x1069C490", Slot = "5")]
    public ExTypes Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ExTypes();
    }

    [Token(Token = "0x60019A3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ExTypesFormatter()
    {
    }
  }
}
