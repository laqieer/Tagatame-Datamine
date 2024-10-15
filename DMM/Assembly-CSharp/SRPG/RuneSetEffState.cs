// Decompiled with JetBrains decompiler
// Type: SRPG.RuneSetEffState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CE5")]
  [MessagePackObject(true)]
  [Serializable]
  public class RuneSetEffState
  {
    [Token(Token = "0x4007149")]
    [FieldOffset(Offset = "0x8")]
    public ParamTypes type;
    [Token(Token = "0x400714A")]
    [FieldOffset(Offset = "0xA")]
    public SkillParamCalcTypes calc;
    [Token(Token = "0x400714B")]
    [FieldOffset(Offset = "0xC")]
    public short vone;

    [Token(Token = "0x60076B2")]
    [Address(RVA = "0x39D940", Offset = "0x39C740", VA = "0x1039D940")]
    public bool Deserialize(JSON_RuneSetEffState json) => new bool();

    [Token(Token = "0x60076B3")]
    [Address(RVA = "0x39D8A0", Offset = "0x39C6A0", VA = "0x1039D8A0")]
    public void CreateBaseStatus(
      EElement element,
      ref BaseStatus addStatus,
      ref BaseStatus scaleStatus,
      bool isDrawBaseStatus)
    {
    }

    [Token(Token = "0x60076B4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneSetEffState()
    {
    }
  }
}
