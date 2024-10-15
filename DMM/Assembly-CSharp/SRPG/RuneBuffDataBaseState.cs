// Decompiled with JetBrains decompiler
// Type: SRPG.RuneBuffDataBaseState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010F2")]
  [MessagePackObject(true)]
  [Serializable]
  public class RuneBuffDataBaseState : RuneBuffData
  {
    [Token(Token = "0x4003D36")]
    [FieldOffset(Offset = "0x8")]
    public RuneLotteryBaseState base_lot;
    [Token(Token = "0x4003D37")]
    [FieldOffset(Offset = "0xC")]
    public short val;
    [Token(Token = "0x4003D38")]
    [FieldOffset(Offset = "0xE")]
    public short slot;

    [Token(Token = "0x6004790")]
    [Address(RVA = "0x11EE0B0", Offset = "0x11ECEB0", VA = "0x111EE0B0")]
    public bool Deserialize(Json_RuneBuffData json) => new bool();

    [Token(Token = "0x6004791")]
    [Address(RVA = "0x11EE260", Offset = "0x11ED060", VA = "0x111EE260")]
    public Json_RuneBuffData Serialize() => (Json_RuneBuffData) null;

    [Token(Token = "0x6004792")]
    [Address(RVA = "0x11EDE80", Offset = "0x11ECC80", VA = "0x111EDE80")]
    public void CreateBaseStatus(
      int enforce,
      ref BaseStatus addStatus,
      ref BaseStatus scaleStatus,
      bool isDrawBaseStatus)
    {
    }

    [Token(Token = "0x6004793")]
    [Address(RVA = "0x11EDDA0", Offset = "0x11ECBA0", VA = "0x111EDDA0")]
    public void CreateBaseStatus(
      int enforce,
      EElement element,
      ref BaseStatus addStatus,
      ref BaseStatus scaleStatus,
      bool isDrawBaseStatus)
    {
    }

    [Token(Token = "0x6004794")]
    [Address(RVA = "0x11EDF60", Offset = "0x11ECD60", VA = "0x111EDF60")]
    public void CreateOnlyBaseStatus(
      int enforce,
      ref BaseStatus addOnlyBaseStatus,
      ref BaseStatus scaleOnlyBaseStatus,
      bool isDrawBaseStatus)
    {
    }

    [Token(Token = "0x6004795")]
    [Address(RVA = "0x11EE000", Offset = "0x11ECE00", VA = "0x111EE000")]
    public void CreateOnlyBaseStatus(
      int enforce,
      EElement element,
      ref BaseStatus addOnlyBaseStatus,
      ref BaseStatus scaleOnlyBaseStatus,
      bool isDrawBaseStatus)
    {
    }

    [Token(Token = "0x6004796")]
    [Address(RVA = "0x11EDEA0", Offset = "0x11ECCA0", VA = "0x111EDEA0")]
    public void CreateDedicatedStatus(
      ref BaseStatus addStatus,
      ref BaseStatus scaleStatus,
      bool isDrawBaseStatus)
    {
    }

    [Token(Token = "0x6004797")]
    [Address(RVA = "0x11EDEC0", Offset = "0x11ECCC0", VA = "0x111EDEC0")]
    public void CreateDedicatedStatus(
      EElement element,
      ref BaseStatus addStatus,
      ref BaseStatus scaleStatus,
      bool isDrawBaseStatus)
    {
    }

    [Token(Token = "0x6004798")]
    [Address(RVA = "0x11EE1E0", Offset = "0x11ECFE0", VA = "0x111EE1E0")]
    public float PowerPercentage() => new float();

    [Token(Token = "0x6004799")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneBuffDataBaseState()
    {
    }
  }
}
