// Decompiled with JetBrains decompiler
// Type: SRPG.AIActionTable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C2F")]
  [MessagePackObject(true)]
  public class AIActionTable
  {
    [Token(Token = "0x4001FE7")]
    [FieldOffset(Offset = "0x8")]
    public List<AIAction> actions;
    [Token(Token = "0x4001FE8")]
    [FieldOffset(Offset = "0xC")]
    public int looped;

    [Token(Token = "0x600304B")]
    [Address(RVA = "0xFD76B0", Offset = "0xFD64B0", VA = "0x10FD76B0")]
    public void Clear()
    {
    }

    [Token(Token = "0x600304C")]
    [Address(RVA = "0xFD7710", Offset = "0xFD6510", VA = "0x10FD7710")]
    public void CopyTo(AIActionTable result)
    {
    }

    [Token(Token = "0x600304D")]
    [Address(RVA = "0xFD7A20", Offset = "0xFD6820", VA = "0x10FD7A20")]
    public AIActionTable()
    {
    }
  }
}
