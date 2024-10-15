// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_MasterParam2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BDA")]
  [Serializable]
  public class JSON_MasterParam2
  {
    [Token(Token = "0x4006BB8")]
    [FieldOffset(Offset = "0x8")]
    public JSON_InitPlayer[] InitPlayer;
    [Token(Token = "0x4006BB9")]
    [FieldOffset(Offset = "0xC")]
    public JSON_InitUnit[] InitUnit;

    [Token(Token = "0x6007301")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_MasterParam2()
    {
    }
  }
}
