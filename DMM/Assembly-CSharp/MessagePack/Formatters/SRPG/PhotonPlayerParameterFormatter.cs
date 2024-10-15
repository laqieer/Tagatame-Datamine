// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.PhotonPlayerParameterFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009D0")]
  public sealed class PhotonPlayerParameterFormatter : 
    IMessagePackFormatter<PhotonPlayerParameter>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001830")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001831")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026BE")]
    [Address(RVA = "0xE75440", Offset = "0xE74240", VA = "0x10E75440")]
    public PhotonPlayerParameterFormatter()
    {
    }

    [Token(Token = "0x60026BF")]
    [Address(RVA = "0xE751E0", Offset = "0xE73FE0", VA = "0x10E751E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      PhotonPlayerParameter value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026C0")]
    [Address(RVA = "0xE74E40", Offset = "0xE73C40", VA = "0x10E74E40", Slot = "5")]
    public PhotonPlayerParameter Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (PhotonPlayerParameter) null;
    }
  }
}
