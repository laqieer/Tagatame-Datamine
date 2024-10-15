// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.StatusTypesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200057A")]
  public sealed class StatusTypesFormatter : 
    IMessagePackFormatter<StatusTypes>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019BC")]
    [Address(RVA = "0x6AB030", Offset = "0x6A9E30", VA = "0x106AB030", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      StatusTypes value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019BD")]
    [Address(RVA = "0x6AAFE0", Offset = "0x6A9DE0", VA = "0x106AAFE0", Slot = "5")]
    public StatusTypes Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new StatusTypes();
    }

    [Token(Token = "0x60019BE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public StatusTypesFormatter()
    {
    }
  }
}
