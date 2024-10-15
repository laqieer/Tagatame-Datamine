// Decompiled with JetBrains decompiler
// Type: SRPG.RuneSlotIndex
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029EE")]
  [MessagePackObject(true)]
  [Serializable]
  public struct RuneSlotIndex
  {
    [Token(Token = "0x400CBBD")]
    [FieldOffset(Offset = "0x0")]
    private byte value;
    [Token(Token = "0x400CBBE")]
    public const byte All = 255;
    [Token(Token = "0x400CBBF")]
    public const byte Min = 0;
    [Token(Token = "0x400CBC0")]
    public const byte Max = 5;
    [Token(Token = "0x400CBC1")]
    public const byte MaxCount = 6;

    [Token(Token = "0x600BF20")]
    [Address(RVA = "0x8668C0", Offset = "0x8656C0", VA = "0x108668C0")]
    public RuneSlotIndex(byte value)
    {
    }

    [Token(Token = "0x600BF21")]
    [Address(RVA = "0x866930", Offset = "0x865730", VA = "0x10866930")]
    public static implicit operator RuneSlotIndex(byte value) => new RuneSlotIndex();

    [Token(Token = "0x600BF22")]
    [Address(RVA = "0x866950", Offset = "0x865750", VA = "0x10866950")]
    public static implicit operator byte(RuneSlotIndex value) => new byte();

    [Token(Token = "0x600BF23")]
    [Address(RVA = "0x866880", Offset = "0x865680", VA = "0x10866880")]
    public static RuneSlotIndex CreateSlotToIndex(int slot) => new RuneSlotIndex();

    [Token(Token = "0x600BF24")]
    [Address(RVA = "0x8668B0", Offset = "0x8656B0", VA = "0x108668B0")]
    public static int IndexToSlot(int index) => new int();
  }
}
