// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EItemTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000558")]
  public sealed class EItemTypeFormatter : IMessagePackFormatter<EItemType>, IMessagePackFormatter
  {
    [Token(Token = "0x6001956")]
    [Address(RVA = "0x69B860", Offset = "0x69A660", VA = "0x1069B860", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EItemType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001957")]
    [Address(RVA = "0x69B810", Offset = "0x69A610", VA = "0x1069B810", Slot = "5")]
    public EItemType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new EItemType();
    }

    [Token(Token = "0x6001958")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EItemTypeFormatter()
    {
    }
  }
}
