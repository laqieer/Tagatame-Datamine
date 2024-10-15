// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RuneLotteryBaseState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CD4")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RuneLotteryBaseState : JSON_RuneLotteryState
  {
    [Token(Token = "0x4007103")]
    [FieldOffset(Offset = "0x18")]
    public int dedicated_val;
    [Token(Token = "0x4007104")]
    [FieldOffset(Offset = "0x1C")]
    public int[] enh_param;

    [Token(Token = "0x6007694")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RuneLotteryBaseState()
    {
    }
  }
}
