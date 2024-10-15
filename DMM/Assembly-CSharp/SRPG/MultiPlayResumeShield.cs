// Decompiled with JetBrains decompiler
// Type: SRPG.MultiPlayResumeShield
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000D93")]
  [MessagePackObject(true)]
  [Serializable]
  public class MultiPlayResumeShield
  {
    [Token(Token = "0x40026B8")]
    [FieldOffset(Offset = "0x8")]
    public string inm;
    [Token(Token = "0x40026B9")]
    [FieldOffset(Offset = "0xC")]
    public int nhp;
    [Token(Token = "0x40026BA")]
    [FieldOffset(Offset = "0x10")]
    public int mhp;
    [Token(Token = "0x40026BB")]
    [FieldOffset(Offset = "0x14")]
    public int ntu;
    [Token(Token = "0x40026BC")]
    [FieldOffset(Offset = "0x18")]
    public int mtu;
    [Token(Token = "0x40026BD")]
    [FieldOffset(Offset = "0x1C")]
    public int drt;
    [Token(Token = "0x40026BE")]
    [FieldOffset(Offset = "0x20")]
    public int dvl;

    [Token(Token = "0x6003730")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public MultiPlayResumeShield()
    {
    }
  }
}
