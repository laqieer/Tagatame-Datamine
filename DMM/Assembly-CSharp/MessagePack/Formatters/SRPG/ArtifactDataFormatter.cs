// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ArtifactDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000792")]
  public sealed class ArtifactDataFormatter : 
    IMessagePackFormatter<ArtifactData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013BC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013BD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002004")]
    [Address(RVA = "0xCD6D80", Offset = "0xCD5B80", VA = "0x10CD6D80")]
    public ArtifactDataFormatter()
    {
    }

    [Token(Token = "0x6002005")]
    [Address(RVA = "0xCD61A0", Offset = "0xCD4FA0", VA = "0x10CD61A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ArtifactData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002006")]
    [Address(RVA = "0xCD5AC0", Offset = "0xCD48C0", VA = "0x10CD5AC0", Slot = "5")]
    public ArtifactData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ArtifactData) null;
    }
  }
}
