// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.eArtifactSortTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200056D")]
  public sealed class eArtifactSortTypeFormatter : 
    IMessagePackFormatter<eArtifactSortType>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001995")]
    [Address(RVA = "0x6B12A0", Offset = "0x6B00A0", VA = "0x106B12A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      eArtifactSortType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001996")]
    [Address(RVA = "0x6B1250", Offset = "0x6B0050", VA = "0x106B1250", Slot = "5")]
    public eArtifactSortType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new eArtifactSortType();
    }

    [Token(Token = "0x6001997")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public eArtifactSortTypeFormatter()
    {
    }
  }
}
