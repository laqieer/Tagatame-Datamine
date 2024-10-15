// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Ext8
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200042D")]
  internal sealed class Ext8 : IExtDecoder
  {
    [Token(Token = "0x4000E7F")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IExtDecoder Instance;

    [Token(Token = "0x60014C2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Ext8()
    {
    }

    [Token(Token = "0x60014C3")]
    [Address(RVA = "0x5BE790", Offset = "0x5BD590", VA = "0x105BE790", Slot = "4")]
    public ExtensionResult Read(byte[] bytes, int offset, out int readSize)
    {
      return new ExtensionResult();
    }

    [Token(Token = "0x60014C4")]
    [Address(RVA = "0x5BE840", Offset = "0x5BD640", VA = "0x105BE840")]
    static Ext8()
    {
    }
  }
}
