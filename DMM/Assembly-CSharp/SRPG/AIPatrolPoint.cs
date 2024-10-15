// Decompiled with JetBrains decompiler
// Type: SRPG.AIPatrolPoint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C34")]
  [MessagePackObject(true)]
  [Serializable]
  public class AIPatrolPoint
  {
    [Token(Token = "0x4001FFF")]
    [FieldOffset(Offset = "0x8")]
    public int x;
    [Token(Token = "0x4002000")]
    [FieldOffset(Offset = "0xC")]
    public int y;
    [Token(Token = "0x4002001")]
    [FieldOffset(Offset = "0x10")]
    public int length;

    [Token(Token = "0x6003052")]
    [Address(RVA = "0xFD7A90", Offset = "0xFD6890", VA = "0x10FD7A90")]
    public void CopyTo(AIPatrolPoint dst)
    {
    }

    [Token(Token = "0x6003053")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AIPatrolPoint()
    {
    }
  }
}
