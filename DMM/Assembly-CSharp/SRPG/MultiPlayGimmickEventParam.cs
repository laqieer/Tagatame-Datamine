// Decompiled with JetBrains decompiler
// Type: SRPG.MultiPlayGimmickEventParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000DA0")]
  [MessagePackObject(true)]
  [Serializable]
  public class MultiPlayGimmickEventParam
  {
    [Token(Token = "0x400271F")]
    [FieldOffset(Offset = "0x8")]
    public int count;
    [Token(Token = "0x4002720")]
    [FieldOffset(Offset = "0xC")]
    public int completed;

    [Token(Token = "0x600373D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public MultiPlayGimmickEventParam()
    {
    }
  }
}
