// Decompiled with JetBrains decompiler
// Type: SRPG.MultiTowerRoundParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018D0")]
  public class MultiTowerRoundParam
  {
    [Token(Token = "0x400597C")]
    [FieldOffset(Offset = "0x8")]
    public int Now;
    [Token(Token = "0x400597D")]
    [FieldOffset(Offset = "0xC")]
    public List<int> Round;

    [Token(Token = "0x6006388")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public MultiTowerRoundParam()
    {
    }
  }
}
