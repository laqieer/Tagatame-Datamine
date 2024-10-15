// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Ext16
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200042E")]
  internal sealed class Ext16 : IExtDecoder
  {
    [Token(Token = "0x4000E80")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IExtDecoder Instance;

    [Token(Token = "0x60014C5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Ext16()
    {
    }

    [Token(Token = "0x60014C6")]
    [Address(RVA = "0x5BDF80", Offset = "0x5BCD80", VA = "0x105BDF80", Slot = "4")]
    public ExtensionResult Read(byte[] bytes, int offset, out int readSize)
    {
      return new ExtensionResult();
    }

    [Token(Token = "0x60014C7")]
    [Address(RVA = "0x5BE050", Offset = "0x5BCE50", VA = "0x105BE050")]
    static Ext16()
    {
    }
  }
}
