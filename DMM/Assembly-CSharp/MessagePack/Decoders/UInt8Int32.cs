// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.UInt8Int32
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003F4")]
  internal sealed class UInt8Int32 : IInt32Decoder
  {
    [Token(Token = "0x4000E4D")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IInt32Decoder Instance;

    [Token(Token = "0x6001425")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt8Int32()
    {
    }

    [Token(Token = "0x6001426")]
    [Address(RVA = "0x5CC880", Offset = "0x5CB680", VA = "0x105CC880", Slot = "4")]
    public int Read(byte[] bytes, int offset, out int readSize) => new int();

    [Token(Token = "0x6001427")]
    [Address(RVA = "0x5CC910", Offset = "0x5CB710", VA = "0x105CC910")]
    static UInt8Int32()
    {
    }
  }
}
