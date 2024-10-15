// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ManipulateTypesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200053D")]
  public sealed class ManipulateTypesFormatter : 
    IMessagePackFormatter<ManipulateTypes>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001905")]
    [Address(RVA = "0x6A1150", Offset = "0x69FF50", VA = "0x106A1150", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ManipulateTypes value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001906")]
    [Address(RVA = "0x6A1100", Offset = "0x69FF00", VA = "0x106A1100", Slot = "5")]
    public ManipulateTypes Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ManipulateTypes();
    }

    [Token(Token = "0x6001907")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ManipulateTypesFormatter()
    {
    }
  }
}
