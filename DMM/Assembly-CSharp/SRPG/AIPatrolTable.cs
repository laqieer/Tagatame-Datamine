// Decompiled with JetBrains decompiler
// Type: SRPG.AIPatrolTable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C33")]
  [MessagePackObject(true)]
  [Serializable]
  public class AIPatrolTable
  {
    [Token(Token = "0x4001FFC")]
    [FieldOffset(Offset = "0x8")]
    public AIPatrolPoint[] routes;
    [Token(Token = "0x4001FFD")]
    [FieldOffset(Offset = "0xC")]
    public int looped;
    [Token(Token = "0x4001FFE")]
    [FieldOffset(Offset = "0x10")]
    public int keeped;

    [Token(Token = "0x600304F")]
    [Address(RVA = "0xFD7AC0", Offset = "0xFD68C0", VA = "0x10FD7AC0")]
    public void Clear()
    {
    }

    [Token(Token = "0x6003050")]
    [Address(RVA = "0xFD7AF0", Offset = "0xFD68F0", VA = "0x10FD7AF0")]
    public void CopyTo(AIPatrolTable dst)
    {
    }

    [Token(Token = "0x6003051")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AIPatrolTable()
    {
    }
  }
}
