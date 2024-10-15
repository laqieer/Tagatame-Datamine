// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.eTeleportTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200054E")]
  public sealed class eTeleportTypeFormatter : 
    IMessagePackFormatter<eTeleportType>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001938")]
    [Address(RVA = "0x6B1980", Offset = "0x6B0780", VA = "0x106B1980", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      eTeleportType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001939")]
    [Address(RVA = "0x6B1930", Offset = "0x6B0730", VA = "0x106B1930", Slot = "5")]
    public eTeleportType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new eTeleportType();
    }

    [Token(Token = "0x600193A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public eTeleportTypeFormatter()
    {
    }
  }
}
