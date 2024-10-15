// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_DuelBonusUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AB3")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_DuelBonusUnit
  {
    [Token(Token = "0x4006301")]
    [FieldOffset(Offset = "0x8")]
    public int rate;
    [Token(Token = "0x4006302")]
    [FieldOffset(Offset = "0xC")]
    public string[] units;

    [Token(Token = "0x6006E17")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_DuelBonusUnit()
    {
    }
  }
}
