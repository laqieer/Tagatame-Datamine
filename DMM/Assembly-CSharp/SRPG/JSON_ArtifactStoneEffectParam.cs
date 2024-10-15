// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ArtifactStoneEffectParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001992")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_ArtifactStoneEffectParam
  {
    [Token(Token = "0x4005D96")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4005D97")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4005D98")]
    [FieldOffset(Offset = "0x10")]
    public string expr;
    [Token(Token = "0x4005D99")]
    [FieldOffset(Offset = "0x14")]
    public int frame;
    [Token(Token = "0x4005D9A")]
    [FieldOffset(Offset = "0x18")]
    public string icon;
    [Token(Token = "0x4005D9B")]
    [FieldOffset(Offset = "0x1C")]
    public string[] abilities;
    [Token(Token = "0x4005D9C")]
    [FieldOffset(Offset = "0x20")]
    public string[] skills;

    [Token(Token = "0x6006836")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ArtifactStoneEffectParam()
    {
    }
  }
}
