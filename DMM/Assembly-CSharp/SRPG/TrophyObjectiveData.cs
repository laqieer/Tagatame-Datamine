// Decompiled with JetBrains decompiler
// Type: SRPG.TrophyObjectiveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B7C")]
  internal class TrophyObjectiveData
  {
    [Token(Token = "0x400D508")]
    [FieldOffset(Offset = "0x8")]
    public TrophyObjective Objective;
    [Token(Token = "0x400D509")]
    [FieldOffset(Offset = "0xC")]
    public string Description;
    [Token(Token = "0x400D50A")]
    [FieldOffset(Offset = "0x10")]
    public int Count;
    [Token(Token = "0x400D50B")]
    [FieldOffset(Offset = "0x14")]
    public int CountMax;

    [Token(Token = "0x600C76A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TrophyObjectiveData()
    {
    }
  }
}
