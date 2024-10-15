// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RunePrideResetParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D0C")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RunePrideResetParam
  {
    [Token(Token = "0x40071DD")]
    [FieldOffset(Offset = "0x8")]
    public string begin_at;
    [Token(Token = "0x40071DE")]
    [FieldOffset(Offset = "0xC")]
    public string end_at;
    [Token(Token = "0x40071DF")]
    [FieldOffset(Offset = "0x10")]
    public JSON_RunePrideResetData[] resets;

    [Token(Token = "0x6007749")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RunePrideResetParam()
    {
    }
  }
}
