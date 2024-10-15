// Decompiled with JetBrains decompiler
// Type: SRPG.RuneBuffDataEvoState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010F3")]
  [MessagePackObject(true)]
  [Serializable]
  public class RuneBuffDataEvoState : RuneBuffData
  {
    [Token(Token = "0x4003D39")]
    [FieldOffset(Offset = "0x8")]
    public RuneLotteryEvoState evo_lot;
    [Token(Token = "0x4003D3A")]
    [FieldOffset(Offset = "0xC")]
    public short val;
    [Token(Token = "0x4003D3B")]
    [FieldOffset(Offset = "0xE")]
    public short slot;

    [Token(Token = "0x600479A")]
    [Address(RVA = "0x11EE3D0", Offset = "0x11ED1D0", VA = "0x111EE3D0")]
    public bool Deserialize(Json_RuneBuffData json) => new bool();

    [Token(Token = "0x600479B")]
    [Address(RVA = "0x11EE4D0", Offset = "0x11ED2D0", VA = "0x111EE4D0")]
    public Json_RuneBuffData Serialize() => (Json_RuneBuffData) null;

    [Token(Token = "0x600479C")]
    [Address(RVA = "0x11EE300", Offset = "0x11ED100", VA = "0x111EE300")]
    public void CreateBaseStatus(
      ref BaseStatus addStatus,
      ref BaseStatus scaleStatus,
      bool isDrawBaseStatus)
    {
    }

    [Token(Token = "0x600479D")]
    [Address(RVA = "0x11EE320", Offset = "0x11ED120", VA = "0x111EE320")]
    public void CreateBaseStatus(
      EElement element,
      ref BaseStatus addStatus,
      ref BaseStatus scaleStatus,
      bool isDrawBaseStatus)
    {
    }

    [Token(Token = "0x600479E")]
    [Address(RVA = "0x11EE1E0", Offset = "0x11ECFE0", VA = "0x111EE1E0")]
    public float PowerPercentage() => new float();

    [Token(Token = "0x600479F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneBuffDataEvoState()
    {
    }
  }
}
