// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixNegativeFloat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003CF")]
  internal sealed class FixNegativeFloat : ISingleDecoder
  {
    [Token(Token = "0x4000E2B")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly ISingleDecoder Instance;

    [Token(Token = "0x60013BC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixNegativeFloat()
    {
    }

    [Token(Token = "0x60013BD")]
    [Address(RVA = "0x5C0230", Offset = "0x5BF030", VA = "0x105C0230", Slot = "4")]
    public float Read(byte[] bytes, int offset, out int readSize) => new float();

    [Token(Token = "0x60013BE")]
    [Address(RVA = "0x5C02B0", Offset = "0x5BF0B0", VA = "0x105C02B0")]
    static FixNegativeFloat()
    {
    }
  }
}
