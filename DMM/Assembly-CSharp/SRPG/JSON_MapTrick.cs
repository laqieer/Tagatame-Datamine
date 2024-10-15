// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_MapTrick
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C02")]
  [Serializable]
  public class JSON_MapTrick
  {
    [Token(Token = "0x4001EB3")]
    [FieldOffset(Offset = "0x8")]
    public string id;
    [Token(Token = "0x4001EB4")]
    [FieldOffset(Offset = "0xC")]
    public int gx;
    [Token(Token = "0x4001EB5")]
    [FieldOffset(Offset = "0x10")]
    public int gy;
    [Token(Token = "0x4001EB6")]
    [FieldOffset(Offset = "0x14")]
    public string tag;

    [Token(Token = "0x600300E")]
    [Address(RVA = "0xFE4B10", Offset = "0xFE3910", VA = "0x10FE4B10")]
    public void CopyTo(JSON_MapTrick dst)
    {
    }

    [Token(Token = "0x600300F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_MapTrick()
    {
    }
  }
}
