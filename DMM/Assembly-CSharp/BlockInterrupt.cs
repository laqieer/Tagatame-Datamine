// Decompiled with JetBrains decompiler
// Type: BlockInterrupt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x200001C")]
public class BlockInterrupt
{
  [Token(Token = "0x400007B")]
  [FieldOffset(Offset = "0x0")]
  private static List<BlockInterrupt> mInstances;
  [Token(Token = "0x400007C")]
  [FieldOffset(Offset = "0x8")]
  private bool mActive;
  [Token(Token = "0x400007D")]
  [FieldOffset(Offset = "0xC")]
  private BlockInterrupt.EType mType;

  [Token(Token = "0x60000A5")]
  [Address(RVA = "0x2C1180", Offset = "0x2BFF80", VA = "0x102C1180")]
  public static bool IsBlocked(BlockInterrupt.EType type) => new bool();

  [Token(Token = "0x60000A6")]
  [Address(RVA = "0x2C0F50", Offset = "0x2BFD50", VA = "0x102C0F50")]
  public static BlockInterrupt Create(BlockInterrupt.EType type) => (BlockInterrupt) null;

  [Token(Token = "0x60000A7")]
  [Address(RVA = "0x2C1000", Offset = "0x2BFE00", VA = "0x102C1000")]
  public void Destroy()
  {
  }

  [Token(Token = "0x60000A8")]
  [Address(RVA = "0x2C1080", Offset = "0x2BFE80", VA = "0x102C1080", Slot = "1")]
  ~BlockInterrupt()
  {
  }

  [Token(Token = "0x60000A9")]
  [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
  public BlockInterrupt()
  {
  }

  [Token(Token = "0x60000AA")]
  [Address(RVA = "0x2C1260", Offset = "0x2C0060", VA = "0x102C1260")]
  static BlockInterrupt()
  {
  }

  [Token(Token = "0x200001D")]
  public enum EType
  {
    [Token(Token = "0x400007F")] NOP,
    [Token(Token = "0x4000080")] ALL,
    [Token(Token = "0x4000081")] PHOTON_DISCONNECTED,
    [Token(Token = "0x4000082")] URL_SCHEME_LAUNCH,
    [Token(Token = "0x4000083")] NUM,
  }
}
