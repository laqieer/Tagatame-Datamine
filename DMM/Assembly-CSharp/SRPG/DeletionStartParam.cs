// Decompiled with JetBrains decompiler
// Type: SRPG.DeletionStartParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002E34")]
  [Serializable]
  public class DeletionStartParam
  {
    [Token(Token = "0x400E843")]
    [FieldOffset(Offset = "0x8")]
    public string device_id;
    [Token(Token = "0x400E844")]
    [FieldOffset(Offset = "0xC")]
    public string secret_key;
    [Token(Token = "0x400E845")]
    [FieldOffset(Offset = "0x10")]
    public string idfa;
    [Token(Token = "0x400E846")]
    [FieldOffset(Offset = "0x14")]
    public string idfv;

    [Token(Token = "0x600DA78")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public DeletionStartParam()
    {
    }
  }
}
