// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ConceptCardLsBuffCoefParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A6C")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_ConceptCardLsBuffCoefParam
  {
    [Token(Token = "0x4006174")]
    [FieldOffset(Offset = "0x8")]
    public int rare;
    [Token(Token = "0x4006175")]
    [FieldOffset(Offset = "0xC")]
    public int[] coefs;
    [Token(Token = "0x4006176")]
    [FieldOffset(Offset = "0x10")]
    public int[] friend_coefs;

    [Token(Token = "0x6006C98")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ConceptCardLsBuffCoefParam()
    {
    }
  }
}
