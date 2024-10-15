// Decompiled with JetBrains decompiler
// Type: SRPG.RuneLotteryState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CD8")]
  [MessagePackObject(true)]
  [Serializable]
  public class RuneLotteryState
  {
    [Token(Token = "0x400710B")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400710C")]
    [FieldOffset(Offset = "0xC")]
    public ParamTypes type;
    [Token(Token = "0x400710D")]
    [FieldOffset(Offset = "0xE")]
    public SkillParamCalcTypes calc;
    [Token(Token = "0x400710E")]
    [FieldOffset(Offset = "0x10")]
    public short lot_min;
    [Token(Token = "0x400710F")]
    [FieldOffset(Offset = "0x12")]
    public short lot_max;

    [Token(Token = "0x6007698")]
    [Address(RVA = "0x399670", Offset = "0x398470", VA = "0x10399670")]
    public bool Deserialize(JSON_RuneLotteryState json) => new bool();

    [Token(Token = "0x6007699")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneLotteryState()
    {
    }
  }
}
