// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_VersusMatchingParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EC6")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_VersusMatchingParam
  {
    [Token(Token = "0x4008125")]
    [FieldOffset(Offset = "0x8")]
    public string key;
    [Token(Token = "0x4008126")]
    [FieldOffset(Offset = "0xC")]
    public int point;

    [Token(Token = "0x6007DFF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_VersusMatchingParam()
    {
    }
  }
}
