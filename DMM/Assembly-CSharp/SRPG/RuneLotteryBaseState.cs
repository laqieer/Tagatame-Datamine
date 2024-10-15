// Decompiled with JetBrains decompiler
// Type: SRPG.RuneLotteryBaseState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CD9")]
  [MessagePackObject(true)]
  [Serializable]
  public class RuneLotteryBaseState : RuneLotteryState
  {
    [Token(Token = "0x4007110")]
    [FieldOffset(Offset = "0x14")]
    public short dedicated_val;
    [Token(Token = "0x4007111")]
    [FieldOffset(Offset = "0x18")]
    public short[] enh_param;

    [Token(Token = "0x600769A")]
    [Address(RVA = "0x399500", Offset = "0x398300", VA = "0x10399500")]
    public bool Deserialize(JSON_RuneLotteryBaseState json) => new bool();

    [Token(Token = "0x600769B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneLotteryBaseState()
    {
    }
  }
}
