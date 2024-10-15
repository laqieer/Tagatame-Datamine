// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BuffTypesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000564")]
  public sealed class BuffTypesFormatter : IMessagePackFormatter<BuffTypes>, IMessagePackFormatter
  {
    [Token(Token = "0x600197A")]
    [Address(RVA = "0x694B50", Offset = "0x693950", VA = "0x10694B50", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BuffTypes value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600197B")]
    [Address(RVA = "0x694B00", Offset = "0x693900", VA = "0x10694B00", Slot = "5")]
    public BuffTypes Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new BuffTypes();
    }

    [Token(Token = "0x600197C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BuffTypesFormatter()
    {
    }
  }
}
