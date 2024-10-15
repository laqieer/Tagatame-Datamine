// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Ext32Header
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000439")]
  internal sealed class Ext32Header : IExtHeaderDecoder
  {
    [Token(Token = "0x4000E8A")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IExtHeaderDecoder Instance;

    [Token(Token = "0x60014E4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Ext32Header()
    {
    }

    [Token(Token = "0x60014E5")]
    [Address(RVA = "0x5BE0B0", Offset = "0x5BCEB0", VA = "0x105BE0B0", Slot = "4")]
    public ExtensionHeader Read(byte[] bytes, int offset, out int readSize)
    {
      return new ExtensionHeader();
    }

    [Token(Token = "0x60014E6")]
    [Address(RVA = "0x5BE170", Offset = "0x5BCF70", VA = "0x105BE170")]
    static Ext32Header()
    {
    }
  }
}
