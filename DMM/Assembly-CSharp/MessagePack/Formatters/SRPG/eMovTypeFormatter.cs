// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.eMovTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000567")]
  public sealed class eMovTypeFormatter : IMessagePackFormatter<eMovType>, IMessagePackFormatter
  {
    [Token(Token = "0x6001983")]
    [Address(RVA = "0x6B17A0", Offset = "0x6B05A0", VA = "0x106B17A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      eMovType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001984")]
    [Address(RVA = "0x6B1750", Offset = "0x6B0550", VA = "0x106B1750", Slot = "5")]
    public eMovType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new eMovType();
    }

    [Token(Token = "0x6001985")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public eMovTypeFormatter()
    {
    }
  }
}
